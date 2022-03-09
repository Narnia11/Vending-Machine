using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Models
{
    public interface IVending
    {
       public void Purchase();
        public void ShowAll();
        public void Details();
        public void InsertMoney();
        public void EndTransaction();

    }
}
