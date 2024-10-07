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
        public List<string> KitcheApplence { get; set; }

        public KitchenArea(string address, string city, string region, string name)
           : base(address, city, region)
        {
            Name = name;
            KitcheApplence = new List<string>() { "Kitchen table with 4 chairs" "Kettle", "microwave", "fridge", "coffee machine" };
        }



        public override void DisplayRoom()
        {
            Console.WriteLine("This is a kitchen room in the office.");
            Console.WriteLine("The kitchen has the following appliances:");

            foreach (var item in KitcheApplence)
            {
                Console.WriteLine($"-  {item}");
            }

        }
    }
}
