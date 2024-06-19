using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace trpo_test_2.models
{
    public class Building
    {
        public int ZbmId { get; set; }
        public string Number { get; set; }
        public override string ToString()
        {
            return $"ZbmId: {ZbmId}, Number: {Number}";
        }

        public Building() { }
        public Building(Zbm zbm, string number)
        {
            ZbmId = zbm.Id;
            Number = number;
        }
    }
}
