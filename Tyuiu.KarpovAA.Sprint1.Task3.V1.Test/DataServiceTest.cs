using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KarpovAA.Sprint1.Task3.V1.Lib;

namespace Tyuiu.KarpovAA.Sprint1.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double r = 2;
            double h = 3;
            double wait = 6;
            var res = ds.CylinderVolume(r, h);
            Assert.AreEqual(wait, res);
        }
    }
}
