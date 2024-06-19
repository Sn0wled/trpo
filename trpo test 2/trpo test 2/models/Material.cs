using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trpo_test_2.models
{
    public class Material
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public decimal AtomicMass { get; set; }
        public override string ToString()
        {
            return $"{Id}, {Type}, {AtomicMass}";
        }
    }
}
