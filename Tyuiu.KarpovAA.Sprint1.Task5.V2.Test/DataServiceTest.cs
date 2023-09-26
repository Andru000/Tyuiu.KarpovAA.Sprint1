using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KarpovAA.Sprint1.Task5.V2.Lib;

namespace Tyuiu.KarpovAA.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double temp = 15;
            DataService ds = new DataService();
            double res = ds.FahrenheitToСelsius(temp);

            int result = Convert.ToInt32(res);

            int wait = -9;
            Assert.AreEqual(wait, result);
        }
    }
}
