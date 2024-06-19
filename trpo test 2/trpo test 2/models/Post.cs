using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trpo_test_2.models
{
    public class Post
    {
        public int Id { get; internal set; }
        public string Name { get; set; } = string.Empty;
        public bool MCHI { get; set; }
        public bool MSUE { get; set; }
        public bool MAUE { get; set; }
        public bool MWUE { get; set; }

        public override string ToString()
        {
            return $"id: {Id}; Name: {Name}, MCHI: {MCHI}, MSUE: {MSUE}, MAUE: {MAUE}, MWUE: {MWUE}";
        }
    }
}
