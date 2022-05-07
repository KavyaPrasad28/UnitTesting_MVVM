using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTesting_MVVM.ViewModel;

namespace BasicMathUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            BasicMathViewModel bmvm = new BasicMathViewModel();
            bmvm.MathModel.Number1 = 5;
            bmvm.MathModel.Number2 = 5;
            bmvm.OnAdd();
            Assert.AreEqual(bmvm.MathModel.Result, 10);
        }

        [TestMethod]
        public void TestSub()
        {
            BasicMathViewModel bmvm = new BasicMathViewModel();
            bmvm.MathModel.Number1 = 5;
            bmvm.MathModel.Number2 = 5;
            bmvm.OnSub();
            Assert.AreEqual(bmvm.MathModel.Result, 0);
        }

        [TestMethod]
        public void TestMul()
        {
            BasicMathViewModel bmvm = new BasicMathViewModel();
            bmvm.MathModel.Number1 = 5;
            bmvm.MathModel.Number2 = 5;
            bmvm.OnMul();
            Assert.AreEqual(bmvm.MathModel.Result, 25);
        }

        [TestMethod]
        public void TestDiv()
        {
            BasicMathViewModel bmvm = new BasicMathViewModel();
            bmvm.MathModel.Number1 = 5;
            bmvm.MathModel.Number2 = 5;
            bmvm.OnDiv();
            Assert.AreEqual(bmvm.MathModel.Result, 1);
        }
    }
}
