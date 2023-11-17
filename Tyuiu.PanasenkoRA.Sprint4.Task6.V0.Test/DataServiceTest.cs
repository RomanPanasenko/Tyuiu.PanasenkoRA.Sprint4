using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PanasenkoRA.Sprint4.Task6.V0.Lib;

namespace Tyuiu.PanasenkoRA.Sprint4.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            var tex = new string[]{ "Microsoft", "Google", "Apple", "Amazon", "Facebook", "Tesla", "Netflix"};

            int res = ds.Calculate(tex);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
