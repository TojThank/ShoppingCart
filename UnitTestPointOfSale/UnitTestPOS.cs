using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCart;

namespace UnitTestPointOfSale
{
    [TestClass]
    public class UnitTestPOS
    {
        string[] items = { "Apple", "Apple", "Orange", "Apple" };
        PointOfSale Pos;
        public UnitTestPOS()
        {
            Pos = new PointOfSale();
        }

        /// <summary>
        /// for item list above the count should be 2
        /// </summary>
        [TestMethod]
        public void TestPOSBillItemCount()
        {
            Assert.IsTrue(Pos.Bills.Count == 2);
        }

       
    }
}
