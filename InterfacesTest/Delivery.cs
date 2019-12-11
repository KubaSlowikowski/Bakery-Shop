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

        public void StartBaking(int hour)
        {

        }
    }
}
