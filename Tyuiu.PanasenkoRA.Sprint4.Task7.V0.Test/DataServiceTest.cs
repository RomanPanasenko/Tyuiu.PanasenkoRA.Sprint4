using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PanasenkoRA.Sprint4.Task7.V0.Lib;

namespace Tyuiu.PanasenkoRA.Sprint4.Task7.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            int rows = 3;
            int columns = 4;
            int[,] mtrx = new int[rows, columns];
            string str = "658932125478";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, columns, str);
            int wait = 30;
            Assert.AreEqual(wait, res);
        }
    }
}
