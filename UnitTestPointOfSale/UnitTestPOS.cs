using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCart;
using System.Collections.Generic;
using System.Linq;
namespace UnitTestPointOfSale
{
    [TestClass]
    public class UnitTestPOS
    {
        
        string[] items = { "Apple", "Apple", "Orange", "Apple" };
        string[] items1 = { "Apple", "Orange", "Orange", "Orange" };
        string[] items2 = { "Apple", "Apple", "Orange", "Orange" };
        string[] items3 = { "Orange", "Orange", "Orange", "Orange" };
        string[] items4 = { "Apple", "Apple", "Apple", "Apple" };

        string[] items5 = { "Apple", "Orange", "Orange", "Orange", "Orange", "Orange", "Orange", "Apple", "Apple", "Apple", "Apple" };
        IDictionary<PointOfSale,double> PosSingleItem;
        IDictionary<PointOfSale, double> PosMultiItem;
        public UnitTestPOS()
        {
            PosMultiItem = new Dictionary<PointOfSale, double>();
            PosSingleItem = new Dictionary<PointOfSale, double>();
            PosMultiItem.Add(new PointOfSale(items),1.45);
            PosMultiItem.Add(new PointOfSale(items1), 1.10);
            PosMultiItem.Add(new PointOfSale(items2), 1.10);
            PosSingleItem.Add(new PointOfSale(items3), 0.75);
            PosSingleItem.Add(new PointOfSale(items4), 1.20);
            PosMultiItem.Add(new PointOfSale(items5), 2.80);
        }

        /// <summary>
        /// for item list above the count should be 2
        /// </summary>
        [TestMethod]
        public void TestPOSBillItemCount()
        {
            foreach (var item in PosMultiItem)
            {
                // count should be 1 for items3 and items4
                Assert.IsTrue(item.Key.Bills.Count == 2 || item.Key.Bills.Count == 1);
            }
            foreach (var item in PosSingleItem)
            {
                // count should be 1 for items3 and items4
                Assert.IsTrue( item.Key.Bills.Count == 1);
            }

        }

        /// <summary>
        /// Final total cost
        /// </summary>
        [TestMethod]
        public void TestPOSBillAmount()
        {
            var Pos = PosSingleItem.Concat(PosMultiItem);
            foreach (var item in Pos)
            {
                double totalCost = item.Key.Bills.Sum(p => p.Cost);
                Assert.IsTrue(totalCost == item.Value);
            }
        }

        /// <summary>
        /// Final total cost after discount
        /// </summary>
        [TestMethod]
        public void TestPOSBillAmountWithOffer()
        {
            var Pos = PosSingleItem.Concat(PosMultiItem);
            foreach (var item in Pos)
            {
                double totalCost = item.Key.Bills.Sum(p => p.Cost);
                Assert.IsTrue(totalCost == item.Value);
            }
        }
    }
}
