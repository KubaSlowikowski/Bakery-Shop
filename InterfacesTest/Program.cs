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
        }
    }
}
