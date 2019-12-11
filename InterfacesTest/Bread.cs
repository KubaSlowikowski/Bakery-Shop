using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesTest
{
    abstract class Bread
    {

        public int Id { get; set; }
        public double Weight { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Grain { get; set; }
        public bool IfBaked { get; set; }
        public abstract void Bake(int ammount);

        public static int BakedCount { get; protected set; }

        public static int SoldCount { get;  private set; }


        public enum PayMethod 
        {
            Card ,
            Cash,
            Phone
        };


        public void Buy(int id, int ammount)
        {
            SoldCount += ammount;
            Price = 2.5;
            //to do return price of concrete product here

            double bill = Price * ammount;   
            Console.WriteLine("Zakupiles {0} sztuk {1} za kwotę {2}", ammount, id, bill);
        }
       
    }
}
