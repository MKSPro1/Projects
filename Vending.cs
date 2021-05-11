


using System;
namespace VendingMachine
{
    public class Vend
    {
        double beginningBalance = 0;
        double price;
        double newBalance;

        public Vend()
        {
        }
        public void CoinInsert(double tendered) // Summing the coins inserted
        {
            if (tendered == .05 || tendered == .10 || tendered == .25 || tendered == .50 || tendered == 1)
            {
                this.beginningBalance += tendered;
                Console.WriteLine("You inserted: $" + String.Format("{0:0.00}", tendered) + "\nYour available balance is: $" + String.Format("{0:0.00}", beginningBalance) + " Please choose another option");
            }
            else
            {
                Console.WriteLine("Please insert a valid coin");
            }
        }
        public void OrderItem(string item)
        {
            Console.WriteLine(" 1 Chips \n 2 Nuts \n 3 Candy \n 4 Beef Jerkey \n 5 Refund");
            string itemSelect = Console.ReadLine();
            bool isValidItem = int.TryParse(itemSelect, out int itemSelectResult);

            if (itemSelectResult == 1)
            {
                price = .50;
                Console.WriteLine("You selected " + itemSelectResult + " - Chips - The price is $" + String.Format("{0:0.00}", price));
            }
            else if (itemSelectResult == 2)
            {
                price = .75;
                Console.WriteLine("You selected " + itemSelectResult + " - Nuts - The price is $" + String.Format("{0:0.00}", price));
            }
            else if (itemSelectResult == 3)
            {
                price = 1.00;
                Console.WriteLine("You selected " + itemSelectResult + " - Candy - The price is $" + String.Format("{0:0.00}", price));
            }
            else if (itemSelectResult == 4)
            {
                price = 1.25;
                Console.WriteLine("You selected " + itemSelectResult + " - Beef Jerkey - The price is $" + String.Format("{0:0.00}", price));
            }
            else
            {
                Console.WriteLine("Please select a valid item number");
            }
        }
        public void GiveRefund()
        {
            Console.WriteLine("Your refund is $" + String.Format("{0:0.00}", newBalance + "\nThank you!"));
        }
        public double KeepBalance(double balance)
        {
            newBalance = beginningBalance -= price;

            Console.WriteLine("Your new balance is $" + String.Format("{0:0.00}", newBalance));
            {
                return newBalance;
            }
        }
    }
}
