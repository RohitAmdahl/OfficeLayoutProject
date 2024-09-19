using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OfficeLayoutProject
{
    internal class KitchenArea : Office
    {
        public string? Name { get; set; }

        public KitchenArea() :base (address, city,region)
        {
            
        }

        public override void DisplayRoom()
        {
            Console.WriteLine($"Kitchen Area: {Name}, Located at {Address}, {City}, {Region}");
        }
    }
}
