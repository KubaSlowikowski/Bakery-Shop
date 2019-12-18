using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesTest
{
    class BasketPosition
    {
        public Bread product { get; set; }
        public int amount { get; set; }

        public BasketPosition(Bread prod, int amt)
        {
            product = prod;
            amount = amt;
        }
        public BasketPosition(Bread prod)
        {
            product = prod;
            amount = 1;
        }
    }
}
