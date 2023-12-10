using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GorbunovAA.Sprint6.Task4.V23.Lib;

namespace Tyuiu.GorbunovAA.Sprint6.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.GetMassFunction(-5, 5);
            var wait = res;
            Assert.AreEqual(res, wait);
        }
    }
}
