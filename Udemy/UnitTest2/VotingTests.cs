using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestDemo2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemo2.Tests
{
    [TestClass()]
    public class VotingTests
    {
        [TestMethod()]
        public void IsEligibleTestfor18()
        {
            int age = 18;
            Voting vote = new Voting("Navaneeth",age);
            string expected = "Eligible";
            string actual=vote.IsEligible(age);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void IsEligibleTestfor17()
        {
            int age = 17;
            Voting vote = new Voting("Navaneeth", age);
            string expected = "Not Eligible";
            string actual = vote.IsEligible(age);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void IsEligibleTestfor18above()
        {
            int age = 19;
            Voting vote = new Voting("Navaneeth", age);
            string expected = "Eligible";
            string actual = vote.IsEligible(age);
            Assert.AreEqual(expected, actual);
        }
    }
}