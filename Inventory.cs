
using System;
namespace VendingMachine
{
    public class Inventory
    {
        double invItem1 = 1;
        double invItem2 = 1;
        double invItem3 = 1;
        double invItem4 = 1;
        double newInv1 = 100;
        double newInv2 = 100;
        double newInv3 = 100;
        double newInv4 = 100;
        double updatedInv1;
        double updatedInv2;
        double updatedInv3;
        double updatedInv4;

        public Inventory()
        {

        }
        public double ItemInventory1(double inventory1)
        {
            updatedInv1 = newInv1 -= invItem1;
            Console.WriteLine("Chips inventory is: " + updatedInv1);
            return updatedInv1;
        }
        public double ItemInventory2(double inventory2)
        {
            updatedInv2 = newInv2 -= invItem2;
            Console.WriteLine("Nuts inventory is: " + newInv2);
            return updatedInv2;
        }
        public double ItemInventory3(double inventory3)
        {
            updatedInv3 = newInv3 -= invItem3;
            Console.WriteLine("Candy inventory is: " + newInv3);
            return updatedInv3;
        }
        public double ItemInventory4(double inventory2)
        {
            updatedInv4 = newInv4 -= invItem4;
            Console.WriteLine("Jerkey inventory is: " + newInv4);
            return updatedInv4;
        }

        public double DisplayInventory(double inventoryDisplay1)
        {
            Console.WriteLine("Chips  inventory is: {0}", updatedInv1);
            return updatedInv1;
        }
    }

}