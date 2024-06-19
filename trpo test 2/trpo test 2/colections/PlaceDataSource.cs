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
    public static class PlaceDataSource
    {
        static NpgsqlDataSource dataSource = Program.dataSource;

        public static void AddPlace(ref Place place)
        {
            using var cmd = dataSource.CreateCommand("select * from add_place(@zbmId, @bNum, @pNum, @rTN)");
            AddParams(place, cmd);
            try
            {
                using var reader = cmd.ExecuteReader();
                reader.Read();
                place = ReadPlace(reader);
            }
            catch (PostgresException ex)
            {
                throw BaseException.HandlePostgresException(ex);
            }
        }

        public static List<Place> GetByBuilding(Building building)
        {
            List<Place> list = new List<Place>();
            using var cmd = dataSource.CreateCommand("select * from Помещение where id_ЗБМ = @zbmId and номер_здания = @bNum");
            cmd.Parameters.AddWithValue("zbmId", building.ZbmId);
            cmd.Parameters.AddWithValue("bNum", building.Number);
            try
            {
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Place place = ReadPlace(reader);
                    list.Add(place);
                }
            }
            catch (PostgresException ex)
            {
                BaseException.HandlePostgresException(ex);
            }
            return list;
        }

        public static void ChangePNum(ref Place place, string newPNum)
        {
            using var cmd = dataSource.CreateCommand("select * from change_p_num(@pNum, @bNum, @zbmId, @newPNum)");
            AddParams(place, cmd);
            cmd.Parameters.AddWithValue("newPNum", newPNum);
            try
            {
                using var reader = cmd.ExecuteReader();
                reader.Read();
                place = ReadPlace(reader);
            }
            catch (PostgresException ex)
            {
                throw BaseException.HandlePostgresException(ex);
            }
        }

        public static void ChangeRespEmp(ref Place place, Employee newRespEmp)
        {
            using var cmd = dataSource.CreateCommand("select * from change_place_resp_emp(@pNum, @bNum, @zbmId, @newRTn)");
            AddParams(place, cmd);
            cmd.Parameters.AddWithValue("newRTn", newRespEmp.TabNum);
            try
            {
                using var reader = cmd.ExecuteReader();
                reader.Read();
                place = ReadPlace(reader);
            }
            catch (PostgresException ex)
            {
                throw BaseException.HandlePostgresException(ex);
            }
        }

        public static void Update(ref Place place, string oldPNum)
        {
            using var cmd = dataSource.CreateCommand("select * from update_place(@zbmId, @bNum, @pNum, @rTn, @oldPNum)");
            AddParams(place, cmd);
            cmd.Parameters.AddWithValue("oldPNum", oldPNum);
            try
            {
                using var reader = cmd.ExecuteReader();
                reader.Read();
                place = ReadPlace(reader);
            }
            catch (PostgresException ex)
            {
                throw BaseException.HandlePostgresException(ex);
            }
        }

        public static void Delete(Place place)
        {
            using var cmd = dataSource.CreateCommand("delete from Помещение where id_ЗБМ = @zbmId and" +
                " номер_здания = @bNum and номер_помещения = @pNum");
            AddParams(place, cmd);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (PostgresException ex)
            {
                throw BaseException.HandlePostgresException(ex);
            }
        }

            static Place ReadPlace(NpgsqlDataReader reader)
            {
                var place = new Place();
                place.ZbmId = reader.GetInt32(0);
                place.EmpTabNum = reader.GetString(1);
                place.BuildingNumber = reader.GetString(2);
                place.Number = reader.GetString(3);
                return place;
            }


            public static List<Place> GetByRespEmpTN(string rTN)
            {
                List<Place> list = new List<Place>();
                using var cmd = dataSource.CreateCommand("select * from Помещение where таб_номер_сотрудника = @rTN");
                cmd.Parameters.AddWithValue("rTN", rTN);
                try
                {
                    using var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Place place = ReadPlace(reader);
                        list.Add(place);
                    }
                }
                catch (PostgresException ex)
                {
                    BaseException.HandlePostgresException(ex);
                }
                return list;
            }

            static void AddParams(Place place, NpgsqlCommand cmd)
            {
                cmd.Parameters.AddWithValue("zbmId", place.ZbmId);
                cmd.Parameters.AddWithValue("bNum", place.BuildingNumber);
                cmd.Parameters.AddWithValue("pNum", place.Number);
                cmd.Parameters.AddWithValue("rTN", place.EmpTabNum);
            }
        }
    }

