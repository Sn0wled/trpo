using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trpo_test_2.exceptions;

namespace trpo_test_2.models
{
    public class UE
    {
        public string SerialNumber { get; set; }
        public int MaterialId { get;  set; }
        public int ZbmId { get;  set; }
        public decimal MaterialWeight { get; set; }
        public string ConteinerInvNum { get; set; }
        public string ScalesInvNum { get; set; }
        public string BuildingNum { get; set; }
        public string PlaceNum { get; set; }
        public string MaterialForm {  get; set; }

        public UE(Material mat, Place place, Scales scales, Container container, decimal weight, string serialNum, string materialForm)
        {
            if (weight > scales.MaxWeight)
            {
                throw new BaseException("Вес материала превышает максимальный вес весов");
            }
            SerialNumber = serialNum;
            MaterialId = mat.Id;
            ZbmId = place.ZbmId;
            MaterialWeight = weight;
            ConteinerInvNum = container.InvNum;
            ScalesInvNum = scales.InvNum;
            BuildingNum = place.BuildingNumber;
            PlaceNum = place.Number;
            MaterialForm = materialForm;
        }

        public void WeightUE(Scales scales, decimal newWeight)
        {

            if (newWeight > scales.MaxWeight)
            {
                throw new BaseException("Вес материала превышает максимальный вес весов");
            }
            ScalesInvNum = scales.InvNum;
            MaterialWeight = newWeight;
        }

        // нет проверки на крит пределы
        public void ChangePlace(Place newPlace)
        {
            ZbmId = newPlace.ZbmId;
            BuildingNum = newPlace.BuildingNumber;
            PlaceNum = newPlace.Number;
        }

        internal UE() { }
    }
}
