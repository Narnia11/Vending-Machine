﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Models
{
    class Sandwich : Products
    {
        public bool ExtraSauce { get; set; }
        public string Size { get; set; }
    }
}
