using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KarpovAA.Sprint1.Task7.V27.Lib;

namespace Tyuiu.KarpovAA.Sprint1.Task7.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 3;
            double wait = -0.567;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
