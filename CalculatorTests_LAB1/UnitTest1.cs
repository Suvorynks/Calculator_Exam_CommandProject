using AnalaizerClassLibrary;
using AnalizerClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;

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
            // 1. Знаходимо приватний метод через рефлексію
            MethodInfo getPriorityMethod = typeof(AnalaizerClass).GetMethod(
                "GetPriority",
                BindingFlags.NonPublic | BindingFlags.Static);

            Assert.IsNotNull(getPriorityMethod, "Метод GetPriority не знайдено!");

            // 2. Викликаємо метод
            object result = getPriorityMethod.Invoke(null, new object[] { operatorSymbol });
            byte actualPriority = Convert.ToByte(result);

            // 3. Порівнюємо результат
            Assert.AreEqual((byte)expectedPriority, actualPriority,
                $"Помилка для оператора '{operatorSymbol}'. Очікувалось: {expectedPriority}, Отримано: {actualPriority}");
        }
    }
}