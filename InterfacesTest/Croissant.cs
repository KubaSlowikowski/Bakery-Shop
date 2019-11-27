using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesTest
{
    class Croissant : Bread
    {
        public string Filling { get; set; }

        public Croissant ()
        {
            this.Name = KindOfBread.Croissant;
            this.Id = (int) KindOfBread.Croissant;
        }
        public override void Bake(int ammount)
        {

        }
    }
}
