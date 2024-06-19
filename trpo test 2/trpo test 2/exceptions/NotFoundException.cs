using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trpo_test_2.exceptions
{
    public class NotFoundException : BaseException
    {
        public NotFoundException(string? message) : base(message)
        {
        }
    }
}
