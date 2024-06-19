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
    public static class UEDataSource
    {
        static NpgsqlDataSource dataSource = Program.dataSource;
        public static void AddUE(ref UE ue)
        {
            using var cmd = dataSource.CreateCommand("select * from add_ue(@serNum, @matId, @matW, @zbmId, @bNum, @pNum, @scInvNum, @contInvNum, @matForm)");
            AddParams(ue, cmd);
            try
            {
                using var reader = cmd.ExecuteReader();
                reader.Read();
                ue = ReadUE(reader);
            }
            catch (PostgresException ex)
            {
                throw BaseException.HandlePostgresException(ex);
            }
        }

        static void AddParams(UE ue, NpgsqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("serNum", ue.SerialNumber); 
            cmd.Parameters.AddWithValue("matId", ue.MaterialId);
            cmd.Parameters.AddWithValue("matW", ue.MaterialWeight);
            cmd.Parameters.AddWithValue("zbmId", ue.ZbmId);
            cmd.Parameters.AddWithValue("bNum", ue.BuildingNum);
            cmd.Parameters.AddWithValue("pNum", ue.PlaceNum);
            cmd.Parameters.AddWithValue("scInvNum", ue.ScalesInvNum);
            cmd.Parameters.AddWithValue("contInvNum", ue.ConteinerInvNum);
            cmd.Parameters.AddWithValue("matForm", ue.MaterialForm);
        }

        static UE ReadUE(NpgsqlDataReader reader)
        {
            UE ue = new();
            ue.MaterialForm = reader.GetString(0);
            ue.MaterialId = reader.GetInt32(1);
            ue.ZbmId = reader.GetInt32(2);
            ue.MaterialWeight = reader.GetDecimal(3);
            ue.SerialNumber = reader.GetString(4);
            ue.ConteinerInvNum = reader.GetString(5);
            ue.ScalesInvNum = reader.GetString(6);
            ue.BuildingNum = reader.GetString(7);
            ue.PlaceNum = reader.GetString(8);
            return ue;
        }
    }
}
