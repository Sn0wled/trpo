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
    public static class PostDatasource
    {
        static NpgsqlDataSource dataSource = Program.dataSource;

        // норм
        public static Post GetById(int id)
        {
            if (dataSource == null) throw new NoDataSourceException();
            using var cmd = dataSource.CreateCommand("select * from get_post_by_id($1)");
            cmd.Parameters.Add(new() { Value = id });
            try
            {
                using var reader = cmd.ExecuteReader();
                reader.Read();
                return ReadPost(reader);
            }
            catch (PostgresException ex)
            {
                throw new Exception(ex.MessageText);
            }
        }

        public static void DelPost(int postId)
        {
            using var cmd = dataSource.CreateCommand("CALL public.del_post(@post_id);");
            cmd.Parameters.Add(new("post_id", postId));
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (PostgresException ex)
            {
                throw new Exception(ex.MessageText);
            }
        }

        // норм
        public static List<Post> GetAll()
        {
            if (dataSource == null) throw new NoDataSourceException();
            List<Post> posts = new List<Post>();
            using var cmd = dataSource.CreateCommand("select * from Должность");
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                posts.Add(ReadPost(reader));
            }
            return posts;
        }

        // норм
        public static void AddPost(ref Post post)
        {
            using var cmd = dataSource.CreateCommand("select * from add_post(@Name, @MCHI, @MSUE, @MAUE, @MWUE)");
            AddParams(post, cmd);
            try
            {
                using var reader = cmd.ExecuteReader();
                reader.Read();
                post = ReadPost(reader);
            }
            catch (PostgresException ex)
            {
                throw new Exception(ex.MessageText);
            }
        }

        // 
        public static void UpdatePost(ref Post post)
        {
            using var cmd = dataSource.CreateCommand("select * from update_post(@Id, @Name, @MCHI, @MSUE, @MAUE, @MWUE)");
            AddParams(post, cmd);
            try
            {
                using var reader = cmd.ExecuteReader();
                reader.Read();
                post = ReadPost(reader);
            }
            catch (PostgresException ex)
            {
                throw new Exception(ex.MessageText);
            }
        }

        private static void AddParams(Post post, NpgsqlCommand cmd)
        {
            cmd.Parameters.Add(new NpgsqlParameter("Id", post.Id));
            cmd.Parameters.Add(new NpgsqlParameter("Name", post.Name));
            cmd.Parameters.Add(new NpgsqlParameter("MCHI", post.MCHI ? 1 : 0));
            cmd.Parameters.Add(new NpgsqlParameter("MSUE", post.MSUE ? 1 : 0));
            cmd.Parameters.Add(new NpgsqlParameter("MAUE", post.MAUE ? 1 : 0));
            cmd.Parameters.Add(new NpgsqlParameter("MWUE", post.MWUE ? 1 : 0));
        }
        private static Post ReadPost(NpgsqlDataReader reader)
        {
            var post = new Post();
            post.Id = reader.GetInt32(0);
            post.Name = reader.GetString(1);
            post.MCHI = reader.GetInt16(2) == 1;
            post.MSUE = reader.GetInt16(3) == 1;
            post.MAUE = reader.GetInt16(4) == 1;
            post.MWUE = reader.GetInt16(5) == 1;
            return post;
        }
    }
}
