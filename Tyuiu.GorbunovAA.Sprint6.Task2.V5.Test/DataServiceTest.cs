using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GorbunovAA.Sprint6.Task2.V5.Lib;

namespace Tyuiu.GorbunovAA.Sprint6.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.GetMassFunction(-5, 5);
            int wait = -9;
            Assert.AreEqual(res[5], wait);
        }
    }
}
