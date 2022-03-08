using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Models
{
    class Money
    {
        int moneyPool = 0;
        int usersMoney;

        private readonly int[] acceptableMony = new int[8] {1, 5, 10, 20, 50,100, 500, 1000 };     //fixed denominations of money

        public int AddToMoneyPool(int usersMoney, int moneyPool)    // users money should be added to the “money pool”
        {
             return usersMoney + moneyPool;
        }

        public bool limitationOfMoneyAmount = Array.Exists(acceptableMony, element => element == usersMoney) //Money should be input in fixed denominations


    }
}
