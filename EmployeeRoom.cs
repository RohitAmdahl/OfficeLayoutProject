using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeLayoutProject
{
    internal class EmployeeRoom : Office
    {
        public string Name { get; set; }
        public EmployeeRoom(string address, string city, string region, string name) :base(address, city, region)
        {
            Name = name;
        }

        public override void DisplayRoom()
        {
            Console.WriteLine("this is Employe room in the office");
        }
    }
}
