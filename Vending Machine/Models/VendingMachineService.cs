using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Models
{
    class VendingMachineService : IVending
    {
        public static int[] moneyDementions = { 1, 5, 10, 20, 50, 100, 500,  1000};
        private readonly List<Product> _products = new List<Product>()
        {
            new Chocolate{Id=1,Cost=50,Name="Chocolate" },

            new Cafee{Id=2,Cost=30,Name="Cafee" },

            new Sandwich{Id=3,Cost=100,Name="Sandwich"}
        };
        public static int moneypool = 0;

        public Product Details(int productId)
        {
            throw new NotImplementedException();
        }

        public string EndTransaction(int ProductID)
        {
            var item = _products.Find(x => x.Id == ProductID);

            return item.Use();
        }

        public bool InsertMoney(int amount)
        {
            if (Array.Exists(moneyDementions, element => element == amount))
            {
                moneypool += amount;
                return true;
            }
            return false;

        }

        public bool Purchase(int productId)
        {
            var item = _products.Find(x => x.Id == productId);
            if (moneypool >= item.Cost)
            {
                moneypool -= item.Cost;
                return true;
            }
            return false;
        }

        public IList<Product> ShowAll()
        {
            return _products;
        }


    }
}
