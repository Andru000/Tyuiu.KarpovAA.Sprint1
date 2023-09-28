using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KarpovAA.Sprint1.Task7.V27.Lib
{
    public class DataService : ISprint1Task7V27
    {
        public double Calculate(double x, double y)
        {
            double res = Math.Round(((Math.Pow(Math.Sin(x), 2) + Math.Cos(y * y)) / (Math.Sin(y) + 1)) - (((x * y) - 12) / (15 + Math.Cos(x))), 3);                         
            return res;
        }
    }
}
    