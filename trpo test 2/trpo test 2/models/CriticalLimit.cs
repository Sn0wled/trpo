using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trpo_test_2.models
{
    public class CriticalLimit
    {
        public int ZbmId { get; set; } 
        public string BuildingNum { get; set; }
        public string PlaceNum { get; set; }
        public int MaterialId { get; set; }
        public decimal LimitMass { get; set; }

        public CriticalLimit(Place place, Material material, decimal limitMass)
        {
            ZbmId = place.ZbmId;
            BuildingNum = place.BuildingNumber;
            PlaceNum = place.Number;
            MaterialId = material.Id;
            LimitMass = limitMass;
        }
        public CriticalLimit() { }

        public override string ToString()
        {
            return $"{ZbmId}, {BuildingNum}, {PlaceNum}, {MaterialId}, {LimitMass}";
        }
    }
}
