using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesTest
{
    class BasketPosition
    {
        public Bread product;
        public int amount;

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
