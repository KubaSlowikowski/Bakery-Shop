using System;

namespace InterfacesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Bread roll = new Roll();
            roll.Buy(10, 10);

            Console.WriteLine(Bread.GetTotalIncome());
        }
    }
}
