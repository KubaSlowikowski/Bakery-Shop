using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesTest
{
    class SunnyBakery : Bakeries, IBakery
    {
        public string Baker { get; set; }

        public void StartBaking(int hour)
        {
            Console.WriteLine($"Starting Baking in {hour} ");
        }
    }
}
