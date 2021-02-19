using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ctbc_prototype.Models
{
    public class ListBarItem
    {
        public List<BarItem> NavBarItems { get; set; }
        public List<BarItem> SideBarItems { get; set; }
    }
}
