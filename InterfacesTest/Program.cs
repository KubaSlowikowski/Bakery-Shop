using System;

namespace InterfacesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Bread roll = new Roll();
            roll.Buy(20, 20);
            Console.WriteLine("Calkowita Zysk {}", Bread.TotalIncome);
        }
    }
}
