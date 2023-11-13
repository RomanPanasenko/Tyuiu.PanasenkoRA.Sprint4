using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PanasenkoRA.Sprint4.Task4.V0.Lib;

namespace Tyuiu.PanasenkoRA.Sprint4.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] { { 3, 3, 1, 1, 4 },
                                          { 2, 4, 2, 1, 5 },
                                          { 2, 2, 2, 2, 2 },
                                          { 1, 5, 4, 5, 4 },
                                          { 1, 2, 3, 2, 4 } };
            int res = ds.Calculate(matrix);
            int wait = 14;

            Assert.AreEqual(wait, res);  
        }
    }
}
