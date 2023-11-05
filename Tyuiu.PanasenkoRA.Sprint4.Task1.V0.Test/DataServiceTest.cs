using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PanasenkoRA.Sprint4.Task1.V0.Lib;

namespace Tyuiu.PanasenkoRA.Sprint4.Task1.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 7, 6, 9, 8, 9, 7, 4, 7, 8, 5, 6, 3, 9, 7, 9, 7 };
            int res = ds.Calculate(array);
            int wait = 79;
            Assert.AreEqual(wait, res);
        }
    }
}
