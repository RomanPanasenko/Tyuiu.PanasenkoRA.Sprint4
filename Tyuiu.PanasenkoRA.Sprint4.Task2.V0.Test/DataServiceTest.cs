using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PanasenkoRA.Sprint4.Task2.V0.Lib;

namespace Tyuiu.PanasenkoRA.Sprint4.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = { 4, 5, 6, 7, 8, 9, 8, 7, 6, 5, 4, 4 };
            int res = ds.Calculate(array);
            int wait = 40;
            Assert.AreEqual(wait, res);
        }
    }
}
