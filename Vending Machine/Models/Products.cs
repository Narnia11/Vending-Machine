using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Models
{
    public abstract class Products
    {
        public abstract void Examine(string uniqueData);

        public abstract void Use();


        public string Name { get; set; }       

        public string Id { get; set; }
        
        public int Cost { get; set; }



    }
}
