using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OfficeLayoutProject
{
    public class KitchenArea : Office
    {
        internal string name;

        public string Name { get; set; }
        public List<string> KitchenEquipments { get; set; }

        public KitchenArea(string address, string city, string region, string name)
           : base(address, city, region)
        {
            Name = name;
            KitchenEquipments = new List<string>();
        }

      

        public override void DisplayRoom()
        {
            Console.WriteLine("this is kitchen room in the office"); 
        }
    }
}
