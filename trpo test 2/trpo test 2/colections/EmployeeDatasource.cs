using Npgsql;
using trpo_test_2.exceptions;
using trpo_test_2.models;

namespace trpo_test_2.colections
{
    public static class EmployeeDatasource
    {
        static NpgsqlDataSource dataSource = Program.dataSource;

        // норм
        public static List<Employee> GetAll()
        {
            if (dataSource == null) throw new NoDataSourceException();
            List<Employee> employees = new List<Employee>();
            using var cmd = dataSource.CreateCommand("select * from emp");
            try
            {
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    employees.Add(ReadEmployee(reader));
                }
            }
            catch (PostgresException ex)
            {
                throw BaseException.HandlePostgresException(ex);
            }
            return employees;
        }

        // норм
        public static Employee GetByTabNum(string tabnum)
        {
            if (dataSource == null) throw new NoDataSourceException();
            using var cmd = dataSource.CreateCommand("select * from get_emp_by_tab_num($1)");
            cmd.Parameters.Add(new() { Value = tabnum });
            try
            {
                using var reader = cmd.ExecuteReader();
                reader.Read();
                return ReadEmployee(reader);
            }
            catch (PostgresException ex)
            {
                throw BaseException.HandlePostgresException(ex);
            }
        }

        // нет обработки превышения длин строк
        public static void Add(ref Employee emp)
        {
            if (dataSource == null) throw new NoDataSourceException();
            using var cmd = dataSource.CreateCommand("select * from add_emp( " +
                "@Fname, @LName, @PName, @PNum, @BDay, @INN, @Address, @PassportSaN, @SNILS, @PostId, @TabNum)");
            AddParams(emp, cmd);
            try
            {
                using var reader = (cmd.ExecuteReader());
                reader.Read();
                emp = ReadEmployee(reader);
            }
            catch (PostgresException ex)
            {
                throw BaseException.HandlePostgresException(ex);
            }
        }

        // норм не тестил, так же не обрабатываются размеры строк
        public static void Update(ref Employee emp, string oldTabNum)
        {
            using var cmd = dataSource.CreateCommand("select * from update_emp( " +
                "@oldTabNum, @Fname, @LName, @PName, @PNum, @BDay, @INN, @Address, @PassportSaN, @SNILS, @PostId, @TabNum)");
            AddParams(emp, cmd);
            cmd.Parameters.Add(new("oldTabNum", oldTabNum));
            try
            {
                using var reader = cmd.ExecuteReader();
                reader.Read();
                emp = ReadEmployee(reader);
            }
            catch (PostgresException ex)
            {
                throw BaseException.HandlePostgresException(ex);
            }
        }

        // норм, не тестил
        public static void Delete(string tabNum)
        {
            using var cmd = dataSource.CreateCommand("call del_emp(@tabNum)");
            cmd.Parameters.AddWithValue("tabNum", tabNum);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (PostgresException ex)
            {
                throw BaseException.HandlePostgresException(ex);
            }
        }

        private static Employee ReadEmployee(NpgsqlDataReader reader)
        {
            Employee emp = new Employee();
            emp.PostId = reader.GetInt32(0);
            emp.LName = reader.GetString(1);
            emp.FName = reader.GetString(2);
            emp.PName = reader.IsDBNull(3) ? null : reader.GetString(3);
            emp.PNum = reader.IsDBNull(4) ? null : reader.GetString(4);
            emp.BDay = reader.GetDateTime(5);
            emp.INN = reader.GetString(6);
            emp.Address = reader.IsDBNull(7) ? null : reader.GetString(7);
            emp.PassportSaN = reader.GetString(8);
            emp.SNILS = reader.GetString(9);
            emp.TabNum = reader.GetString(10);
            emp.PostName = reader.GetString(11);
            return emp;
        }

        private static void AddParams(Employee employee, NpgsqlCommand cmd)
        {
            cmd.Parameters.Add(new NpgsqlParameter("FName", employee.FName));
            cmd.Parameters.Add(new NpgsqlParameter("LName", employee.LName));
            cmd.Parameters.Add(new NpgsqlParameter("PName", employee.PName == null ? DBNull.Value : employee.PName));
            cmd.Parameters.Add(new NpgsqlParameter("PNum", employee.PNum == null ? DBNull.Value : employee.PNum));
            cmd.Parameters.Add(new NpgsqlParameter("BDay", DateOnly.FromDateTime(employee.BDay)));
            cmd.Parameters.Add(new NpgsqlParameter("INN", employee.INN));
            cmd.Parameters.Add(new NpgsqlParameter("Address", employee.Address == null ? DBNull.Value : employee.Address));
            cmd.Parameters.Add(new NpgsqlParameter("PassportSaN", employee.PassportSaN));
            cmd.Parameters.Add(new NpgsqlParameter("SNILS", employee.SNILS));
            cmd.Parameters.Add(new NpgsqlParameter("PostId", employee.PostId));
            cmd.Parameters.Add(new NpgsqlParameter("TabNum", employee.TabNum));
        }
    }
}
