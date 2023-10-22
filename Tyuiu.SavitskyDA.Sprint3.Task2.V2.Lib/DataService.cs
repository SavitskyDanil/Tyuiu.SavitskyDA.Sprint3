using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SavitskyDA.Sprint3.Task2.V2.Lib
{
    public class DataService : ISprint3Task2V2
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double p = 1;
            do
            {
               p = p * (Math.Sin(0.1) + startValue);
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(p, 3);
        }
    }
}
