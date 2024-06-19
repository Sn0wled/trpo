using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trpo_test_2.models
{
    public abstract class Container
    {
        public string InvNum { get; set; }
        public string Type { get; set; }
        public decimal Weight { get; set; }
        public override string ToString()
        {
            return $"{InvNum}, {Type}, {Weight}";
        }
    }
}
