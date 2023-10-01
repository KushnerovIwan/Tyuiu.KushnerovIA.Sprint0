using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KushnerovIA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KushnerovIA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetVessageValid()
        {
            var name = "Иван";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Иван", res);
        }
    }
}
