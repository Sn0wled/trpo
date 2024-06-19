using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trpo_test_2.exceptions
{
    internal class ColumnException : BaseException
    {
        public ColumnException(string? message) : base(message)
        {
        }
        public string ColName { get; init; }
    }
}
