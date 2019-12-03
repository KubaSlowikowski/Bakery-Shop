using System;

namespace InterfacesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Croissant Croissant = new Croissant();
            Roll roll = new Roll();
            roll.Buy(10, 10);
            Croissant.Bake(3, 3, 3);
          
        }
    }
}
