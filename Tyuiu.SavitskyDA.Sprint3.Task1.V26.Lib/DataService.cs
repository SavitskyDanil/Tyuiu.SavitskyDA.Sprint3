using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SavitskyDA.Sprint3.Task1.V26.Lib
{
    public class DataService : ISprint3Task1V26
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sum = 0;
            while (startValue <= stopValue)
            {
                sum = sum + Math.Pow((6 / (Math.Pow(value, startValue))), 2); ;
                startValue++;
            }
            return Math.Round(sum, 3);
        }
    }
}
