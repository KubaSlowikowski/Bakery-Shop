using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesTest
{

    class Basket : IBasket
    {
       
        
        static List<BasketPosition> BasketList = new List<BasketPosition>();


        public void AddToBasket(Bread ProductToAdd)
        {
            if( BasketList.Count == 0)
            {
                Console.WriteLine("Dodaje produkt");
                BasketPosition PositionToAdd = new BasketPosition(ProductToAdd);
                BasketList.Add(PositionToAdd);
                return;
            }
            for (int i = 0; i < BasketList.Count; i++)
            {
                if (BasketList[i].product == ProductToAdd)
                {
                    BasketList[i].amount += 1;
                    return;
                }
                else
                {
                    Console.WriteLine("Dodaje produkt");
                    BasketPosition PositionToAdd = new BasketPosition(ProductToAdd);
                    BasketList.Add(PositionToAdd);
                    return;
                }
            }
        }
        public void AddToBasket(params BasketPosition[] PositionsToAdd)
        {
            for (int i = 0; i<PositionsToAdd.Length; i++)
            {
                for( int j = 0; j<Basket.BasketList.Count; j++)
                {
                    if ( PositionsToAdd[i].product == BasketList[i].product)
                    {
                        BasketList[j].amount += PositionsToAdd[i].amount;
                    }
                    else
                    {
                        BasketList.Add(PositionsToAdd[i]);
                    }
                }
            }
            
        }
        public void RemoveFromBasket(BasketPosition positionToRemove)
        {

        }
        public void BuyFromBasket()
        {

        }

        public void ShowBasket()
        {
            Console.WriteLine("Jestem w ShowBasket");
            foreach(BasketPosition element in BasketList)
            {
                Console.WriteLine($"Product: {element.product}, amount: {element.amount}");
            }
        }
    }
}
