using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemo.Tests
{
    [TestClass()]
    public class BankAccountTests
    {
        [TestMethod()]
        public void DebitTest()
        {
            BankAccount bank = new BankAccount("Navaneeth", 2);
            bank.Debit(2);
            Assert.AreEqual(0, bank.Balance);
        }
        [TestMethod]
        public void CreditTest()
        {
            BankAccount bank = new BankAccount("Navaneeth", 2);
            bank.Credit(2);
            Assert.AreEqual(4, bank.Balance);
        }
        [TestMethod]
        public void CreditDebitTest()
        {
            BankAccount bank = new BankAccount("Navaneeth", 2);
            bank.Debit(2);
            bank.Credit(2);
            Assert.AreEqual(2, bank.Balance);
        }
    }
}