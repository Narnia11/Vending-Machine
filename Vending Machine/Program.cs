using System;
using System.Collections.Generic;
using System.Linq;
using Vending_Machine.Models;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome");
                VendingMachineService vm = new VendingMachineService();
                List<int> purchaseItemIds = new List<int>();
                /*show all products*/
                IList<Product> items = vm.ShowAll();
                foreach (Product item in items)
                {

                    Console.WriteLine($"item code is :{item.Id} item name is: {item.Name} and cost is: {item.Cost}");
                }
                /*End show all products*/


                Boolean purchaseFlag = true;
                while (purchaseFlag)
                {
                    Console.WriteLine("to purchase an item please insert item code");
                    Console.WriteLine("to Discard please inter 0");
                    var itemCode = (Console.ReadLine());
                    if (Convert.ToInt32(itemCode) == 0)
                    {
                        purchaseFlag = false;
                        break;
                    }
                    if (int.TryParse(itemCode, out int value))
                    {

                        if (items.Any(x => x.Id == value))
                        {
                            if (vm.Purchase((Convert.ToInt32(itemCode))))
                            {
                                purchaseItemIds.Add(Convert.ToInt32(itemCode));
                            }
                            else
                            {

                                Console.WriteLine($@"money pool is {VendingMachineService.moneypool} too low  if you want to insert money enter 1 and for exit enter 0");
                                var answer = Console.ReadLine();
                                if (Convert.ToInt32(answer) == 1)
                                {
                                    Console.WriteLine("plese insert money");
                                    if (vm.InsertMoney(Convert.ToInt32(Console.ReadLine())))
                                    {
                                        Console.WriteLine("the money added successfully");
                                    }
                                    else
                                    {
                                        Console.WriteLine("something went wrong !try agin");
                                    }
                                }
                                else
                                {
                                    purchaseFlag = false;

                                }


                            }
                        }
                    }


                }//end while
                Console.WriteLine($"please catch your change {VendingMachineService.moneypool}$");
                if (purchaseItemIds.Count > 0)
                {
                    foreach (var item in purchaseItemIds)
                    {
                        Console.WriteLine(vm.EndTransaction(item));
                    }

                }
                Console.WriteLine($"Goodby");


            }
            catch (Exception e)
            {
                Console.WriteLine("somthing went wrong \n please contact with administrator");
            }

            Console.ReadKey();
        }
    }
}