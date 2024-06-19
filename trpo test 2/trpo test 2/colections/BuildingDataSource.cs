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
    public static class BuildingDataSource
    {
        static NpgsqlDataSource dataSource = Program.dataSource;

        public static void AddBuilding(ref Building building)
        {
            using var cmd = dataSource.CreateCommand("select * from add_building(@buildingNum, @zbmId)");
            AddParams(building, cmd);
            try
            {
                using var reader = cmd.ExecuteReader();
                reader.Read();
                building = ReadBuilding(reader);
            }
            catch (PostgresException ex)
            {
                throw BaseException.HandlePostgresException(ex);
            }
        }

        public static List<Building> GetByZbm(Zbm zbm)
        {
            List<Building> list = new List<Building>();
            using var cmd = dataSource.CreateCommand("select * from Здание where id_ЗБМ = @id");
            cmd.Parameters.AddWithValue("id", zbm.Id);
            using var reader = cmd.ExecuteReader();
            while (reader.Read()) { 
                list.Add(ReadBuilding(reader));
            }
            return list;
        }

        public static void Update(ref Building building, string oldBNum)
        {
            using var cmd = dataSource.CreateCommand("select * from update_building(@buildingNum, @oldBuildingNum, @zbmId)");
            AddParams(building, cmd);
            cmd.Parameters.AddWithValue("oldBuildingNum", oldBNum);
            try
            {
                using var reader = cmd.ExecuteReader();
                reader.Read();
                building = ReadBuilding(reader);
            }
            catch (PostgresException ex)
            {
                throw BaseException.HandlePostgresException(ex);
            }
        }

        private static Building ReadBuilding(NpgsqlDataReader reader)
        {
            Building building = new Building();
            building.Number = reader.GetString(0);
            building.ZbmId = reader.GetInt32(1);
            return building;
        }

        public static void Delete(Building building)
        {
            using var cmd = dataSource.CreateCommand("call del_build(@zbmId, @buildingNum)");
            AddParams(building, cmd);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (PostgresException ex)
            {
                throw BaseException.HandlePostgresException(ex);
            }
        }
        private static void AddParams(Building building, NpgsqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("zbmId", building.ZbmId);
            cmd.Parameters.AddWithValue("buildingNum", building.Number);
        }
    }
}
