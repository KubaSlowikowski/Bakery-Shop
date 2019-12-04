using System;
using System.Collections.Generic;
using System.Text;
namespace InterfacesTest
{
    class Program
    {
        
        static void Main(string[] args)
        {
             
           int totalBakedCount = 0;
           Bread roll = new Roll();
            roll.Bake(10);
            Bread croisant = new Croissant();
            croisant.Bake(5);
            roll.Buy(10, 10);
            croisant.Buy(2, 8);
           
          
            Console.WriteLine("Dakery baked {0} breads ", Bread.BakedCount);
            Console.WriteLine("Dakery sold {0} breads ", Bread.SoldCount) ;

        }
    }
}
