using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trpo_test_2.models
{
    public class Place
    {
        public int ZbmId { get; set; }
        public string BuildingNumber { get; set; }
        public string Number { get; set; }
        public string EmpTabNum { get; set; }
        public override string ToString()
        {
            return $"ZbmId: {ZbmId}, BuildingNumber: {BuildingNumber}, Number: {Number}, EmpTabNum: {EmpTabNum}";
        }
        public Place() { }
        public Place(Building building, string pNum, Employee respEmp)
        {
            ZbmId = building.ZbmId;
            BuildingNumber = building.Number;
            Number = pNum;
            EmpTabNum = respEmp.TabNum;
        }
    }
}
