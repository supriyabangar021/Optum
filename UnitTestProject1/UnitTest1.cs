using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachine;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAcceptingCoins()
        {
            AcceptingCoins.AcceptCoins(0.05);
        }


        [TestMethod]
        public void TestProductSelected()
        {
            ProductSelected.selectProduct("chips",0.50);
        }
    }
}
