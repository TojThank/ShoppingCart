using ShoppingCart;
using System;

namespace POSConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruitlist = { "Apple", "Apple", "Orange", "Apple" };
            PointOfSale POS = new PointOfSale(fruitlist);
            Console.WriteLine("Billing ");
            Console.WriteLine("Item\tQty\tAmount");
            double totalCost = 0;
            foreach (Bill bill in POS.Bills)
            {
                Console.WriteLine("{0}\t{1}\t{2}", bill.Description, bill.Quantity, bill.Cost);
                totalCost += bill.Cost;
            }
            Console.WriteLine("Total:\t\t{0}", totalCost);
        }
    }
}
