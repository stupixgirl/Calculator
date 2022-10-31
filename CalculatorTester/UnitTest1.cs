using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1
    {
        public Calculation cal;
        [TestInitialize]
        public void setup()
        {
            this.cal = new Calculation(10, 5);
        }
        [TestMethod]
        public void TestAddOperation()
        {
            Assert.AreEqual(cal.Execute("+"), 15);
        }
        [TestMethod]
        public void TestSubOperation()
        {
            Assert.AreEqual(cal.Execute("-"), 5);
        }
        [TestMethod]
        public void TestMulOperation()
        {
            Assert.AreEqual(cal.Execute("*"), 50);
        }
        [TestMethod]
        public void TestDivOperation()
        {
            Assert.AreEqual(cal.Execute("/"), 2);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivByZero()
        {
            Calculation c = new Calculation(2,0);
            c.Execute("/");
        }
     /* [TestMethod]
           public void TestDivRound()
         {
             Calculation c = new Calculation(5, 3);
             Assert.AreEqual(c.Execute("/"), 2); 
         }*/

    }
}
