using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trpo_test_2.models
{
    public class Scales
    {
        public string InvNum { get; set; }
        public string Brand { get; set; }
        public DateOnly CalibrationDate { get; set; }
        public decimal MaxWeight { get; set; }
        public decimal Error {  get; set; }
        public override string ToString()
        {
            return $"{InvNum}, {Brand}, {CalibrationDate}, {MaxWeight}, {Error}";
        }
    }
}
