using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesTest
{
    interface IBread
    {
        int Amount { get; set; }
        void Bake(int amount, int sugar, int flower);
    }
}
