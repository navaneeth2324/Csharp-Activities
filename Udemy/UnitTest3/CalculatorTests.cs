using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestDemo3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemo3.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void addTest()
        {
            
            Calculator val = new Calculator();
            int expected = 25;
            int actual = val.add(12, 13);
            Assert.AreEqual(expected, actual);
            expected = 0;
            actual = val.add(0, 0);
            Assert.AreEqual(expected, actual);
            expected = -3;
            actual = val.add(-1, -2);
            Assert.AreEqual(expected, actual);
            
        }
        [TestMethod()]
        public void subtest()
        {

            Calculator val = new Calculator();
            int expected = 10;
            int actual = val.sub(20, 10);
            Assert.AreEqual(expected, actual);
            expected = 0;
            actual = val.sub(10, 10);
            Assert.AreEqual(expected, actual);
            expected = -3;
            actual = val.sub(6, 9);
            Assert.AreEqual(expected, actual);
            expected = -3;
            actual = val.sub(-6, -3);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void prodtest()
        {

            Calculator val = new Calculator();
            int expected = 200;
            int actual = val.prod(20, 10);
            Assert.AreEqual(expected, actual);
            expected = 0;
            actual = val.prod(0, 10);
            Assert.AreEqual(expected, actual);
            expected = -10;
            actual = val.prod(5, -2);
            Assert.AreEqual(expected, actual);
            expected = 6;
            actual = val.prod(-2, -3);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void divtest()
        {

            Calculator val = new Calculator();
            int expected = 5;
            int actual = val.Div(10, 2);
            Assert.AreEqual(expected, actual);
            expected = 1;
            actual = val.Div(3, 2);
            Assert.AreEqual(expected, actual);
            expected = -5;
            actual = val.Div(10, -2);
            Assert.AreEqual(expected, actual);
            expected = 5;
            actual = val.Div(-10, -2);
            Assert.AreEqual(expected, actual);

        }
    }
}