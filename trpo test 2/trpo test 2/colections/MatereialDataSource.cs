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
    public static class MatereialDataSource
    {
        static NpgsqlDataSource dataSource = Program.dataSource;
        // вроде затестил
        public static void AddMaterial(ref Material material)
        {
            using var cmd = dataSource.CreateCommand("select * from add_material(@type, @am)");
            AddParams(material, cmd);
            try
            {
                using var reader = cmd.ExecuteReader();
                reader.Read();
                material = ReadMaterial(reader);
            }
            catch (PostgresException ex)
            {
                throw BaseException.HandlePostgresException(ex);
            }
        }

        public static List<Material> GetAll()
        {
            List<Material> list = new List<Material>();
            using var cmd = dataSource.CreateCommand("select * from Материал");
            try
            {
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Material material = ReadMaterial(reader);
                    list.Add(material);
                }
                return list;
            }
            catch (PostgresException ex)
            {
                throw BaseException.HandlePostgresException(ex);
            }
        }

        public static Material GetByPK(int id)
        {
            using var cmd = dataSource.CreateCommand("select * from get_material_by_pk(@id)");
            cmd.Parameters.AddWithValue("id", id);
            try
            {
                using var reader = cmd.ExecuteReader();
                reader.Read();
                return ReadMaterial(reader);
            }
            catch (PostgresException ex)
            {
                throw BaseException.HandlePostgresException(ex);
            }
        }

        // можно менять все кроме id
        public static void UpdateMaterial(ref Material material)
        {
            using var cmd = dataSource.CreateCommand("select * from update_material(@id, @type, @am)");
            AddParams(material, cmd);
            try
            {
                using var reader = cmd.ExecuteReader();
                reader.Read();
                material = ReadMaterial(reader);
            }
            catch (PostgresException ex)
            {
                throw BaseException.HandlePostgresException(ex);
            }
        }

        public static void DeleteMaterial(Material material)
        {
            using var cmd = dataSource.CreateCommand("call delete_material(@id)");
            AddParams(material, cmd);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (PostgresException ex)
            {
                throw BaseException.HandlePostgresException(ex);
            }
        }

        static void AddParams(Material material, NpgsqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("id", material.Id);
            cmd.Parameters.AddWithValue("type", material.Type);
            cmd.Parameters.AddWithValue("am", material.AtomicMass);
        }

        static Material ReadMaterial(NpgsqlDataReader reader)
        {
            var material = new Material();
            material.Id = reader.GetInt32(0);
            material.Type = reader.GetString(1);
            material.AtomicMass = reader.GetDecimal(2);
            return material;
        }
    }
}
