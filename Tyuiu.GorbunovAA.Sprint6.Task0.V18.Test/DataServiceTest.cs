using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GorbunovAA.Sprint6.Task0.V18.Lib;

namespace Tyuiu.GorbunovAA.Sprint6.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(3);
            var wait = 1.056;
            Assert.AreEqual(res, wait);
        }
    }
}
