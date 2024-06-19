using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trpo_test_2.exceptions
{
    public class BaseException : Exception
    {
        public BaseException(string? message) : base(message)
        {
        }

        public static BaseException HandlePostgresException(PostgresException ex)
        {
            return new BaseException(ex.MessageText);
        }
    }
}
