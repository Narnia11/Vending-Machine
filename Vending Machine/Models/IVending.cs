using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Models
{
    public interface IVending

    {
        public bool Purchase(int productId);
        public IList<Product> ShowAll();
        public Product Details(int productId);
        public bool InsertMoney(int amount);
        public string EndTransaction(int ProductID);

    }
}