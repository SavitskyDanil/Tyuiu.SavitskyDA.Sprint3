using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SavitskyDA.Sprint3.Task0.V28.Lib
{
    public class DataService : ISprint3Task0V28
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 1;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                sumSeries = sumSeries * ((Math.Pow(value, 3) * i) + 2);
            }
            return Math.Round(sumSeries, 3);
        }
    }
}

