using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PanasenkoRA.Sprint4.Task5.V0.Lib;

namespace Tyuiu.PanasenkoRA.Sprint4.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            
            int[,] mtrx = new int[3, 3] { { -3, 5, 1 },
                                          { -5, 6, -3 },
                                          { 7, 1, -4 } };
            int res = ds.Calculate(mtrx);
            int wait = 20;
            Assert.AreEqual(wait, res);
        }
    }
}
