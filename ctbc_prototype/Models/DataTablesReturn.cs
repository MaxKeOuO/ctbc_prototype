using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ctbc_prototype.Models
{
    public class DataTablesReturn
    {
        public int Draw { get; set; }
        public int RecordsTotal { get; set; }
        public int RecordsFiltered { get; set; }
        public object Data { get; set; }
    }
}
