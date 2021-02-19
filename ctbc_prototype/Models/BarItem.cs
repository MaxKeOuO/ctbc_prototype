using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ctbc_prototype.Models
{
    public class BarItem
    {
        public string ItemName { get; set; }

        public string ItemHref { get; set; }

        public string Icon { get; set; }

        public bool OpenOtherWindow { get; set; }

        public int FuncOrder { get; set; }

        public List<BarItem> Children { get; set; }
    }
}
