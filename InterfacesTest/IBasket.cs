using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesTest
{
    interface IBasket
    {
        public void AddToBasket(params Bread[] product);
        // public void addToBasket(params Bread[] product); product + amount
        public void RemoveFromBasket(Bread product);
        public void BuyFromBasket();
    }
}
