using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SavitskyDA.Sprint3.Task1.V26.Lib;

namespace Tyuiu.SavitskyDA.Sprint3.Task1.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int value = 5;
            int startValue = 1;
            int stopValue = 8;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 1.5;
            Assert.AreEqual(wait, res);
        }
    }
}
