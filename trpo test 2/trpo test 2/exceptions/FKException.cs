using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trpo_test_2.exceptions
{
    internal class FKException : BaseException
    {
        public FKException(string? message) : base(message)
        {
        }
        public string[] colNames;
    }
}
