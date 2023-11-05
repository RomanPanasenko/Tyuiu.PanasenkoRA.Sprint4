using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PanasenkoRA.Sprint4.Task3.V0.Lib;

namespace Tyuiu.PanasenkoRA.Sprint4.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5] { { 7, 4, 2, 5, 3 }, { 4, 3, 2, 5, 6 }, { 6, 3, 4, 7, 5 }, { 5, 7, 4, 3, 8 }, { 7, 8, 8, 5, 6 } };
            int res = ds.Calculate(array);
            int wait = 13;
            Assert.AreEqual(wait, res);








        }
    }
}
