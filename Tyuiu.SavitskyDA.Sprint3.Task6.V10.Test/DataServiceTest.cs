using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SavitskyDA.Sprint3.Task6.V10.Lib;

namespace Tyuiu.SavitskyDA.Sprint3.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            //Вариант 10 Напишите программу, которая ищет среди целых чисел, принадлежащих числовому отрезку[20, 32] сумму всех делителей больше 12
            DataService ds = new DataService();
            int startValue = 20;
            int stopValue = 32;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 396;
            Assert.AreEqual(wait, res);
        }
    }
}
