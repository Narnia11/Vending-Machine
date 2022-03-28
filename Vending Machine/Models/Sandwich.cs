using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Models
{
    class Sandwich : Product
    {

        public bool ExtraSauce { get; set; }
        public string Size { get; set; }

        public override Product Examine()
        {
            return new Sandwich { Id = this.Id, Name = this.Name, Cost = this.Cost };
        }

        public override string Use()
        {
            return "Enjoy eating your sandwich";
        }
    }
}
