using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KarpovAA.Sprint1.Task4.V26.Lib
{
    public class DataService : ISprint1Task4V26
    {
        public double Calculate(double x, double y)
        {
            double e = 2.71828;
            var res = Math.Round((Math.Atan(x) + y)/ Math.Pow(e, x + y), 3);
            return res;
            
        }
    }
}
