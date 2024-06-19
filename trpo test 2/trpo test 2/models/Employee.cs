using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trpo_test_2.models
{
    public class Employee
    {
        public string TabNum { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string? PName { get; set; }
        public string? PNum { get; set; }
        public DateTime BDay { get; set; }
        public string INN { get; set; }
        public string? Address { get; set; }
        public string PassportSaN { get; set; }
        public string SNILS { get; set; }
        public int PostId { get; set; }
        public string PostName { get; set; }

        public override string ToString()
        {
            return $"FName: {FName}, LName: {LName}, PName: {PName}, PNum: {PNum}, BDay: {BDay.Date}, INN: {INN}, Address: {Address}, PassportSaN: {PassportSaN},\n\t" +
                $"SNILS: {SNILS}, PostId: {PostId}, TabNum: {TabNum}, PostName: {PostName}";
        }
    }
}
