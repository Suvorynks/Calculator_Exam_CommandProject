using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalaizerClassLibrary;

namespace CalculatorTestsLAB1
{
    [TestClass]
    public class PriorityTests
    {
        [DataTestMethod]
        [DataRow("+", 1)]
        [DataRow("-", 1)]
        [DataRow("*", 2)]
        [DataRow("/", 2)]
        [DataRow("%", 3)]
        [DataRow("(", 0)]
        public void GetPriority_TestDataDriven(string operatorSymbol, int expectedPriority)
        {
            MethodInfo getPriorityMethod = typeof(AnalaizerClass).GetMethod(
                "GetPriority", 
                BindingFlags.NonPublic | BindingFlags.Static);

            Assert.IsNotNull(getPriorityMethod, "Метод GetPriority не знайдено!");

            object result = getPriorityMethod.Invoke(null, new object[] { operatorSymbol });
            byte actualPriority = Convert.ToByte(result);

            Assert.AreEqual((byte)expectedPriority, actualPriority);
        }
    }
}