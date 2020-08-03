using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorAccountTests
    {
        [TestMethod]
        public void Test_AddMethod()
        {

            int res = Program.Add(10, 10);
            Assert.AreEqual(res, 20);
        }

       [TestMethod]
        public void Test_SubstractMethod()
        {
            
            int res = Program.Substract(10, 10);
            Assert.AreEqual(res, 0);

        }
        [TestMethod]
        public void Test_DivideMethod()
        {
          
            int res = Program.divide(10, 5);
            Assert.AreEqual(res, 2);
        }

     
        [TestMethod]
        public void Test_MultiplyMethod()
        {
           
           int res = Program.Multiply(10, 10);
            Assert.AreEqual(res, 100);
        }
    }

}
