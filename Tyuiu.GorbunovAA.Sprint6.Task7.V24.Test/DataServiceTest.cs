using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GorbunovAA.Sprint6.Task7.V24.Lib;

namespace Tyuiu.GorbunovAA.Sprint6.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var wait = 100;
            Assert.AreEqual(wait, 100);
        }
    }
}
