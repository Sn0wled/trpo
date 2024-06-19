using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trpo_test_2.exceptions
{
    internal class CheckException : ColumnException
    {
        public CheckException(string? message) : base(message)
        {
        }
    }
}
