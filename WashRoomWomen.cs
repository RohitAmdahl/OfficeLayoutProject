﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeLayoutProject
{
    internal class WashRoomWomen
    {
        public string? Name { get; set; }
        public WashRoomWomen(string address, string city, string region, string name) : base(address, city, region)
        {
        }
    }
}
