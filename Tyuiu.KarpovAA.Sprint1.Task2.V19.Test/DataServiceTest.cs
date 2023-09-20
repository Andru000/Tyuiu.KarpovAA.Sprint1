﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            int x = 2;
            var res = ds.ConvertInchToKm(x);
            Assert.AreEqual(4, res);
        }
    }
}
