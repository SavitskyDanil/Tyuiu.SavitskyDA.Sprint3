using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SavitskyDA.Sprint3.Task3.V19.Lib
{
    public class DataService : ISprint3Task3V19
    {
        public string ReplaceCharOnNum(string value, char replaceable, char replacement)
        {
            foreach (char c in value)
            {
                if (c == replaceable)
                {
                    value = value.Replace(c, replacement);
                }
            }
            return value;
        }
    }
}
