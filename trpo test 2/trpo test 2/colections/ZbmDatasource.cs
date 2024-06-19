using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trpo_test_2.exceptions;
using trpo_test_2.models;

namespace trpo_test_2.colections
{
    public static class ZbmDatasource
    {
        private static NpgsqlDataSource dataSource = Program.dataSource;

        // норм
        public static List<Zbm> GetAll()
        {
            if (dataSource == null) throw new NoDataSourceException();
            List<Zbm> zbmList = new List<Zbm>();
            using var cmd = dataSource.CreateCommand("select * from ЗБМ");
            try
            {
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    zbmList.Add(ReadZbm(reader));
                }
            } catch (PostgresException ex)
            {
                BaseException.HandlePostgresException(ex);
            }
            return zbmList;
        }

        // норм
        public static void AddZbm(ref Zbm zbm)
        {
            using var cmd = dataSource.CreateCommand("select * from add_zbm(@name);");
            AddParams(zbm, cmd);
            try
            {
                using var reader = cmd.ExecuteReader();
                reader.Read();
                zbm = ReadZbm(reader);
            } catch (PostgresException ex)
            {
                throw BaseException.HandlePostgresException(ex);
            }
        }

        private static Zbm ReadZbm(NpgsqlDataReader reader)
        {
            return new Zbm()
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1)
            };
        }

        public static void UpdateZbm(ref Zbm zbm)
        {
            using var cmd = dataSource.CreateCommand("select * from update_zbm(@id, @name)");
            AddParams(zbm, cmd);
            try
            {
                using var reader = cmd.ExecuteReader();
                reader.Read();
                zbm = ReadZbm(reader);
            }
            catch (PostgresException ex)
            {
                throw BaseException.HandlePostgresException(ex);
            }
        }

        public static void Delete(Zbm zbm)
        {
            using var cmd = dataSource.CreateCommand("call del_zbm(@id)");
            AddParams(zbm, cmd);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (PostgresException ex)
            {
                throw BaseException.HandlePostgresException(ex);
            }
        }

        private static void AddParams(Zbm zbm, NpgsqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("id", zbm.Id);
            cmd.Parameters.AddWithValue("name", zbm.Name);
        }
    }
}
