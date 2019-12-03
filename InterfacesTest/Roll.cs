using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesTest
{
  


    class Roll : Bread, IBread
    {
        public string Shape { get; set; }
        public bool IfCrossed { get; set; }
        public int Amount { get; set; }


        public Roll()
        {
        }

        public void Bake(int amount, int Flower, int Sugar)
        {
             Console.WriteLine("Zamowienie na {0} bulek, do przygotowania {1}g maki i {2}g cukru!", amount, Flower, Sugar);
        }





    


    }
}