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
            this.Name = KindOfBread.Roll;
            this.Id = (int) KindOfBread.Roll;
            this.Shape = null;
            this.IfCrossed = false;
        }
        public override void Bake(int ammount)
        {
            Console.WriteLine($"Bedziemy potrzebowac {ammount} {Shape}, {IfCrossed} bulek ");
        }

    }
}