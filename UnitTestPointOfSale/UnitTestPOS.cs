using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCart;
using System.Linq;
namespace UnitTestPointOfSale
{
    [TestClass]
    public class UnitTestPOS
    {
        string[] items = { "Apple", "Apple", "Orange", "Apple" };
        PointOfSale Pos;
        public UnitTestPOS()
        {
            Pos = new PointOfSale(items);
        }

        /// <summary>
        /// for item list above the count should be 2
        /// </summary>
        [TestMethod]
        public void TestPOSBillItemCount()
        {
            Assert.IsTrue(Pos.Bills.Count == 2);
        }

        /// <summary>
        /// Final total cost
        /// </summary>
        [TestMethod]
        public void TestPOSBillAmount()
        {
            double totalCost = Pos.Bills.Sum(p => p.Cost);
            Assert.IsTrue(totalCost == 2.05);
        }

        /// <summary>
        /// Final total cost after discount
        /// </summary>
        [TestMethod]
        public void TestPOSBillAmountWithOffer()
        {
            double totalCost = Pos.Bills.Sum(p => p.Cost);
            Assert.IsTrue(totalCost == 1.45);
        }
    }
}
