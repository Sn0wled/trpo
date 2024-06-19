using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trpo_test_2.models
{
    public class CubeContainer : Container
    {
        public int Length { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", {Length}, {Height}, {Width}";
        }
    }
}
