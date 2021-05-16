using System;

namespace VendingMachine
{
    class Program
    {
        static void methodOrder(Vend order)
        {
            order.OrderItem("");
        }
        static void methodNewBalance(Vend balance)
        {
            balance.KeepBalance(0.00);
        }
        static void methodRefund(Vend change)
        {
            change.GiveRefund();
        }
        static void methodCoinDenom(Vend vend)
        {
            Console.WriteLine("Please insert a coin:");
            string coinDenom = Console.ReadLine();
            bool isDoubleCoin = double.TryParse(coinDenom, out double coinDenomResult);

            if (isDoubleCoin)
            {
                vend.CoinInsert(coinDenomResult);
            }
            else
            {
                Console.WriteLine("Please enter a valid coin");
            }
        }
        static void Main(string[] args)
        {
            Vend select1 = new Vend();
            while (true)
            {
                Console.WriteLine("Type \n 'I' to Insert Coin \n 'R' to Refund \n 'O' to Order Item \n 'E' to Exit");
                string option = Console.ReadLine();
                if (option.ToUpper() == "I")
                {
                    methodCoinDenom(select1);
                }
                else if (option.ToUpper() == "R")
                {
                    methodRefund(select1);
                    break;
                }
                else if (option.ToUpper() == "O")
                {
                    methodOrder(select1);
                    {
                        methodNewBalance(select1);
                    }
                }
                else if (option.ToUpper() == "E")
                {
                    methodRefund(select1);
                    break;

                    // Console.WriteLine("Thank you for your business!");
                }
                else
                {
                    Console.WriteLine("Please input a valid option");
                }
            }
            Console.ReadLine();
        }
    }
}








