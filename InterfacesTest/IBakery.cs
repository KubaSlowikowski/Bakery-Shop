using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesTest
{
    interface IBakery
    {
        string Baker { get; set; }

        void StartBaking(int hour);
    }
}
