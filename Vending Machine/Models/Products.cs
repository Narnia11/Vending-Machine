using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Models
{
    public abstract class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public int Cost { get; set; }

        public abstract Product Examine();

        public abstract string Use();

    }
}

