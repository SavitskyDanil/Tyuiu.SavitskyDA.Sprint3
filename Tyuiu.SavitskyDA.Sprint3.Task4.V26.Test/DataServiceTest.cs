using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SavitskyDA.Sprint3.Task4.V26.Lib;

namespace Tyuiu.SavitskyDA.Sprint3.Task4.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            // Вариант 26 На отрезке, где x принимает значения от -5 до 5, вычислить значение функции y = (cos(x) - sin(x)) / x При х = 0 пропустить значение. Полученные значения суммировать.
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            double wait = -0.858;
            Assert.AreEqual(wait, res);
        }
    }
}
