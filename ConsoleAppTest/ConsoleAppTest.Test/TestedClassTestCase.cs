using System;
using ConsoleAppNet;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleAppTest.Test
{
    [TestClass]
    public class TestedClassTestCase
    {
        [TestMethod]
        public void TestMethodSum()
        {
            Assert.AreEqual(3, TestedClass.SumTwo(1));
        }
    }
}
