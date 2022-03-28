using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Models
{
    class Chocolate : Product
    {


        public bool Diet { get; set; }
        public string Brand { get; set; }

        public override Product Examine()
        {
            return new Chocolate { Id = this.Id, Name = this.Name, Cost = this.Cost };
        }

        public override string Use()
        {
            return "Enjoy eating your chocolate!";
        }
    }
}