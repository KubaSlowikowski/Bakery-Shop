﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesTest
{
    class CloudyBakery : Bakeries, IBakery
    {
        public string Baker { get; set; }

        public void StartBaking(int hour)
        {

        }
    }
}
