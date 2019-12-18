using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesTest
{
    abstract class Bakeries
    {
        public BakeryNames BakeryName { get; set; }
        public enum BakeryNames
        {
            CloudyBakery,
            SunnyBakery
        };
    }
}
