using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeLayoutProject
{
    public abstract class Office
    { 
        // properties 
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }

        // constructor 

        public Office(string address, string city, string region)
        { 
            Address = address;
            City = city;
            Region = region;
        }

        public abstract void DisplayRoom();
        
    }

}
   