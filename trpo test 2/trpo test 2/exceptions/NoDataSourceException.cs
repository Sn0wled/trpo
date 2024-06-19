using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trpo_test_2.exceptions
{
    public class NoDataSourceException : BaseException
    {
        public NoDataSourceException(): base("Не задан datasource") { }
    }
}
