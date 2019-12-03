using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesTest
{
   

    class Croissant : Bread, IBread
    {
        public string Filling { get; set; }
        public int Amount { get; set; }


        public void Bake(int amount, int flower, int sugar)
        {
            Console.WriteLine("Zamowiono {0} Croissantow. Potrzebne bedzie {0}g cukru i {1}g maki", amount, sugar, flower);
        }
    }
}
