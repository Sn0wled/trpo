using Npgsql;
using trpo_test_2.exceptions;
using trpo_test_2.models;

namespace trpo_test_2.colections
{
    public static class ContainerDataSource
    {
        static NpgsqlDataSource dataSource = Program.dataSource;
        public static void AddCubeContainer(ref CubeContainer cubeContainer)
        {
            using var cmd = dataSource.CreateCommand("select * from add_cube_container(@inv_num, @type, @weight, @len, @width, @height)");
            AddCubeConteinerParams(cubeContainer, cmd);
            try
            {
                using var reader = cmd.ExecuteReader();
                reader.Read();
                cubeContainer = ReadCubeContainer(reader);
            }
            catch (PostgresException ex)
            {
                throw BaseException.HandlePostgresException(ex);
            }
        }

        public static List<CubeContainer> GetAllCube()
        {
            List<CubeContainer> cubeList = new List<CubeContainer>();
            using var cmd = dataSource.CreateCommand("select * from cube_cont");
            try
            {
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cubeList.Add(ReadCubeContainer(reader));
                }
                return cubeList;
            }
            catch (PostgresException ex)
            {
                throw BaseException.HandlePostgresException(ex);
            }
        }

        public static List<CylindricalContainer> GetAllCyl()
        {
            List<CylindricalContainer> cubeList = new List<CylindricalContainer>();
            using var cmd = dataSource.CreateCommand("select * from cyl_cont");
            try
            {
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cubeList.Add(ReadCylindricalContainer(reader));
                }
                return cubeList;
            }
            catch (PostgresException ex)
            {
                throw BaseException.HandlePostgresException(ex);
            }
        }

        public static void AddCylCont(ref CylindricalContainer container)
        {
            using var cmd = dataSource.CreateCommand("select * from add_cyl_cont(@inv_num, @type, @weight, @height, @diameter);");
            AddCylindricalContainerParams(container, cmd);
            try
            {
                using var reader = cmd.ExecuteReader();
                reader.Read();
                container = ReadCylindricalContainer(reader);
            }
            catch (PostgresException ex)
            {
                throw BaseException.HandlePostgresException(ex);
            }
        }

        public static void AddContainer(ref Container container)
        {
            if (container is CubeContainer cubeContainer)
            {
                AddCubeContainer(ref cubeContainer);
            }
            else if (container is CylindricalContainer cylindricalContainer)
            {
                AddCylCont(ref cylindricalContainer);
            }
        }

        public static CubeContainer GetCubeContainer(string invNum)
        {
            using var cmd = dataSource.CreateCommand("select * from get_cube_container(@invNum)");
            cmd.Parameters.AddWithValue("invNum", invNum);
            try
            {
                using var reader = cmd.ExecuteReader();
                reader.Read();
                return ReadCubeContainer(reader);
            }
            catch (PostgresException ex)
            {
                throw BaseException.HandlePostgresException(ex);
            }
        }

        public static CylindricalContainer GetCylindricalContainer(string invNum)
        {
            using var cmd = dataSource.CreateCommand("select * from get_cyl_container(@invNum)");
            cmd.Parameters.AddWithValue("invNum", invNum);
            try
            {
                using var reader = cmd.ExecuteReader();
                reader.Read();
                return ReadCylindricalContainer(reader);
            }
            catch (PostgresException ex)
            {
                throw BaseException.HandlePostgresException(ex);
            }
        }

        public static Container GetContainer(string invNum)
        {
            try
            {
                return GetCubeContainer(invNum);
            }
            catch (BaseException)
            {
                try
                {
                    return GetCylindricalContainer(invNum);
                }
                catch
                {
                    throw new BaseException("Не найден контейнер с инв. номером " + invNum);
                }
            }
        }

        public static void UpdateCubeContainer(ref CubeContainer cubeContainer, string oldInvNum)
        {
            using var cmd = dataSource.CreateCommand("select * from update_cube_container(@inv_num, @type, @weight, @len, @width, @height, @oldInvNum)");
            cmd.Parameters.AddWithValue("oldInvNum", oldInvNum);
            AddCubeConteinerParams(cubeContainer, cmd);
            try
            {
                using var reader = cmd.ExecuteReader();
                reader.Read();
                cubeContainer = ReadCubeContainer(reader);
            }
            catch (PostgresException ex)
            {
                throw BaseException.HandlePostgresException(ex);
            }
        }

        public static void UpdateCylContainer(ref CylindricalContainer container, string oldInvNum)
        {
            using var cmd = dataSource.CreateCommand("select * from update_cyl_cont(@inv_num, @type, @weight, @height, @diameter, @oldInvNum)");
            AddCylindricalContainerParams(container, cmd);
            cmd.Parameters.AddWithValue("oldInvNum", oldInvNum);
            try
            {
                using var reader = cmd.ExecuteReader();
                reader.Read();
                container = ReadCylindricalContainer(reader);
            }
            catch (PostgresException ex)
            {
                throw BaseException.HandlePostgresException(ex);
            }
        }

        public static void UpdateContainer(ref Container container, string oldInvNum)
        {
            if (container is CubeContainer cubeContainer)
            {
                UpdateCubeContainer(ref cubeContainer, oldInvNum);
                container = cubeContainer;
            }
            else if (container is CylindricalContainer cylindricalContainer)
            {
                UpdateCylContainer(ref cylindricalContainer, oldInvNum);
                container = cylindricalContainer;
            }
        }

        public static void Delete(Container container)
        {
            using var cmd = dataSource.CreateCommand("call del_conteiner(@inv_num)");
            cmd.Parameters.AddWithValue("inv_num", container.InvNum);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (PostgresException ex)
            {
                throw BaseException.HandlePostgresException(ex);
            }
        }

        static void AddContainerParams(Container container, NpgsqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("inv_num", container.InvNum);
            cmd.Parameters.AddWithValue("type", container.Type);
            cmd.Parameters.AddWithValue("weight", container.Weight);
        }

        static void AddCubeConteinerParams(CubeContainer container, NpgsqlCommand cmd)
        {
            AddContainerParams(container, cmd);
            cmd.Parameters.AddWithValue("len", container.Length);
            cmd.Parameters.AddWithValue("width", container.Width);
            cmd.Parameters.AddWithValue("height", container.Height);
        }

        static void AddCylindricalContainerParams(CylindricalContainer cylindricalContainer, NpgsqlCommand cmd)
        {
            AddContainerParams(cylindricalContainer, cmd);
            cmd.Parameters.AddWithValue("height", cylindricalContainer.Height);
            cmd.Parameters.AddWithValue("diameter", cylindricalContainer.Diameter);
        }

        // для других чтений
        static void ReadContainer(NpgsqlDataReader reader, Container container)
        {

            container.InvNum = reader.GetString(0);
            container.Type = reader.GetString(1);
            container.Weight = reader.GetDecimal(2);
        }

        static CubeContainer ReadCubeContainer(NpgsqlDataReader reader)
        {
            var cubeContainer = new CubeContainer();
            ReadContainer(reader, cubeContainer);
            cubeContainer.Length = reader.GetInt32(3);
            cubeContainer.Width = reader.GetInt32(4);
            cubeContainer.Height = reader.GetInt32(5);
            return cubeContainer;
        }

        static CylindricalContainer ReadCylindricalContainer(NpgsqlDataReader reader)
        {
            var cylindricalContainer = new CylindricalContainer();
            ReadContainer(reader, cylindricalContainer);
            cylindricalContainer.Height = reader.GetInt32(3);
            cylindricalContainer.Diameter = reader.GetInt32(4);
            return cylindricalContainer;
        }
    }
}
