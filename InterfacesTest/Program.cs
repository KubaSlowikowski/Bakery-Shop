using System;

namespace InterfacesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Bread product = new Roll();
            product.Buy(10, 10);

            product = new Croissant();

            Delivery delivery = new Delivery(new SunnyBakery());
            delivery.Deliver("15:22");

            Basket NowyBasket = new Basket();
            NowyBasket.AddToBasket(product);
            NowyBasket.AddToBasket(product);
            product = new Roll();
            NowyBasket.AddToBasket(product);
            NowyBasket.ShowBasket();
        }
    }
}
