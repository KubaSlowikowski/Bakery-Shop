using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesTest
{
    class Delivery
    {
        IBakery bakery = null;

        public Delivery(IBakery b)
        {
            bakery = b;
        }

        public void Deliver(string time)
        {
            Console.WriteLine($"Delivered products for {bakery.GetType().Name} at {time}");
        }
    }
}
