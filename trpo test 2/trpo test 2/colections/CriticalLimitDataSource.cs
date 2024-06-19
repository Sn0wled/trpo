using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using trpo_test_2.exceptions;
using trpo_test_2.models;

namespace trpo_test_2.colections
{
    public static class CriticalLimitDataSource
    {
        static NpgsqlDataSource dataSource = Program.dataSource;

        public static void Add(ref CriticalLimit limit)
        {
            using var cmd = dataSource.CreateCommand("select * from add_critical_limit(@mId, @zbmId, @bNum, @pNum, @critW)");
            AddParams(limit, cmd);
            try
            {
                using var reader = cmd.ExecuteReader();
                reader.Read();
                limit = ReadLimit(reader);
            }
            catch (PostgresException ex)
            {
                throw BaseException.HandlePostgresException(ex);
            }
        }

        static void AddParams(CriticalLimit limit, NpgsqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("mId", limit.MaterialId);
            cmd.Parameters.AddWithValue("zbmId", limit.ZbmId);
            cmd.Parameters.AddWithValue("bNum", limit.BuildingNum);
            cmd.Parameters.AddWithValue("pNum", limit.PlaceNum);
            cmd.Parameters.AddWithValue("critW", limit.LimitMass);
        }

        static CriticalLimit ReadLimit(NpgsqlDataReader reader)
        {
            CriticalLimit limit = new();
            limit.MaterialId = reader.GetInt32(0);
            limit.ZbmId = reader.GetInt32(1);
            limit.LimitMass = reader.GetDecimal(2);
            limit.BuildingNum = reader.GetString(3);
            limit.PlaceNum = reader.GetString(4);
            return limit;
        }
    }
}
