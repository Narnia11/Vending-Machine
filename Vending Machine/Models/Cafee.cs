using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Models
{
    class Cafee : Product
    {
        public bool WithExtraCream { get; set; }
        public string Size { get; set; }

        public override Product Examine()
        {
            return new Cafee { Id = this.Id, Name = this.Name, Cost = this.Cost };
        }

        public override string Use()
        {
            return "Enjoy drinking your cafee!";
        }
    }
}
