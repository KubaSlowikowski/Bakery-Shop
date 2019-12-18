using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesTest
{
    public class Roll : Bread
    {
        public string Shape { get; set; }
        public bool IfCrossed { get; set; }

        public Roll()
        {
            this.Name = KindOfBread.Roll;
            this.Id = (int) KindOfBread.Roll;
        }
        public override void Bake(int ammount)
        {

        }

    }
}