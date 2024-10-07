using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeLayoutProject
{
    internal class BoosRom : Office
    {
        public string? Name { get; set; }
        public BoosRom(string address, string city, string region, string name) : base(address, city, region)
        {
            Name = name;
        }
        public override void DisplayRoom()
        {
            Console.WriteLine("this is Boss room in the office");
        }
    }
}
