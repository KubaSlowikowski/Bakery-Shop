using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesTest
{
    class Basket
    {
        public struct BasketPosition
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
        List<BasketPosition> BasketList = new List<BasketPosition>();

        public void AddToBasket(params BasketPosition[] PositionToAdd)
        {
            foreach (BasketPosition element in BasketList)
            {
                if(element.product == PositionToAdd.product)
                {

                }
            }
        }
        // public void addToBasket(params Bread[] product); product + amount
        public void RemoveFromBasket(BasketPosition positionToRemove)
        {

        }
        public void BuyFromBasket()
        {

        }
    }
}
