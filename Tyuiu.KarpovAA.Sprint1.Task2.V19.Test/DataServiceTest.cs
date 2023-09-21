using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KarpovAA.Sprint1.Task2.V19.Lib;

namespace Tyuiu.KarpovAA.Sprint1.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 6, b = 4;

            int x = 30 / 6 + 4;

            a++;

            x += b += a;
        }
    }
}
