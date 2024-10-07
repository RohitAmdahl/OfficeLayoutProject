using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeLayoutProject
{
    internal class WashRoomMan : Office
    {
        public string? Name { get; set; } 
        public WashRoomMan(string address, string city, string region, string name) :base (address,city,region)
        {
            Name = Name;
        }
    }
}
