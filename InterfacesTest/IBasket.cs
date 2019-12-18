using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesTest
{
    interface IBasket
    {
        public void AddToBasket(Bread ProductToAdd);
        public void AddToBasket(params BasketPosition[] PositionsToAdd);
        public void RemoveFromBasket(BasketPosition PositionToRemove);
        public void BuyFromBasket();
        public void ShowBasket();
    }
}
