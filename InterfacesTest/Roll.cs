using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesTest
{
    class Roll : Bread
    {
        public string Shape { get; set; }
        public bool IfCrossed { get; set; }
        public Roll()
        {
        }
        public override void Bake(int ammount)
        {
            BakedCount += ammount;
            


        }
    }
}