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
    public static class ScalesDataSource
    {
        static NpgsqlDataSource dataSource = Program.dataSource;
        // норм
        public static void AddScales(ref Scales scales)
        {
            using var cmd = dataSource.CreateCommand("select * from add_scales(@invNum, @brand, @cDate, @maxW, @error)");
            AddParams(scales, cmd);
            try
            {
                using var reader = cmd.ExecuteReader();
                reader.Read();
                scales = ReadScales(reader);
            }
            catch (PostgresException ex)
            {
                throw BaseException.HandlePostgresException(ex);
            }
        }

        public static List<Scales> GetAll()
        {
            List<Scales> scales = new List<Scales>();
            using var cmd = dataSource.CreateCommand("select * from Весы");
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                scales.Add(ReadScales(reader));
            }
            return scales;
        }

        public static void UpdateScales(ref Scales scales, string oldInvNum)
        {
            using var cmd = dataSource.CreateCommand("select * from update_scales(@invNum, @brand, @cDate, @maxW, @error, @oldInvNum)");
            AddParams(scales, cmd);
            cmd.Parameters.AddWithValue("oldInvNum", oldInvNum);
            try
            {
                using var reader = cmd.ExecuteReader();
                reader.Read();
                scales = ReadScales(reader);
            }
            catch (PostgresException ex)
            {
                throw BaseException.HandlePostgresException(ex);
            }
        }

        public static Scales GetByPK(string invNum)
        {
            using var cmd = dataSource.CreateCommand("select * from get_scales_by_pk(@invNum)");
            cmd.Parameters.AddWithValue("invNum", invNum);
            try
            {
                using var reader = cmd.ExecuteReader();
                reader.Read();
                return ReadScales(reader);
            }
            catch (PostgresException ex)
            {
                throw BaseException.HandlePostgresException(ex);
            }
        }

        public static void Delete(Scales scales)
        {
            using var cmd = dataSource.CreateCommand("call del_scales(@invNum)");
            cmd.Parameters.AddWithValue("invNum", scales.InvNum);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (PostgresException ex)
            {
                throw BaseException.HandlePostgresException(ex);
            }
        }

        static void AddParams(Scales scales, NpgsqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("invNum", scales.InvNum);
            cmd.Parameters.AddWithValue("brand", scales.Brand);
            cmd.Parameters.AddWithValue("cDate", scales.CalibrationDate);
            cmd.Parameters.AddWithValue("maxW", scales.MaxWeight);
            cmd.Parameters.AddWithValue("error", scales.Error);
        }

        static Scales ReadScales(NpgsqlDataReader reader)
        {
            Scales scales = new Scales();
            scales.InvNum = reader.GetString(0);
            scales.Brand = reader.GetString(1);
            scales.CalibrationDate = DateOnly.FromDateTime(reader.GetDateTime(2));
            scales.MaxWeight = reader.GetDecimal(3);
            scales.Error = reader.GetDecimal(4);
            return scales;
        }
    }
}
