using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesTest
{
    public abstract class Bread
    {
        public int Id { get; set; }
        public double Weight { get; set; }
        public KindOfBread Name { get; set; }
        public double Price { get; set; }
        public string Grain { get; set; }
        public bool IfBaked { get; set; }
        public abstract void Bake(int ammount);

        public enum KindOfBread
        {
            Roll=1,
            Croissant
        };

        //Add an enum with kinds of bread: roll and croissant
        public double Buy(int id, int ammount)
        {
            Price = 2.5;

            //to do return price of concrete product here

            double bill = Price * ammount;   
            Console.WriteLine("Zakupiles {0} sztuk {1} za kwotę {2}", ammount, id, bill);
            return bill;
        }
    }
}
