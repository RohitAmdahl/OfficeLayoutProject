using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeLayoutProject
{
    internal class Reception : Office
    {
        public string Name { get; set; }
        public Reception(string name, string address, string city, string region) : base(address, city, region)
        {
            Name = name
        }
        public override void DisplayRoom()
        {
            Console.WriteLine("this is Reception room in the office");
        }
    }
}
