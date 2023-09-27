using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KarpovAA.Sprint1.Task6.V18.Lib;

namespace Tyuiu.KarpovAA.Sprint1.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string strTest = "1234";
            DataService ds = new DataService();
            bool res = ds.CheckNumber(strTest);
            string wait = "true";
            Assert.AreEqual(wait, res);
        }
    }
}
