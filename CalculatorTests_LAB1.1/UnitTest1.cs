using AnalaizerClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;

namespace CalculatorTestsLAB1
{
    [TestClass]
    public class PriorityTestsClass
    {
        // Контекст для доступу до бази даних
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("System.Data.SqlClient",
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CalculatorTestsLAB1;Integrated Security=True",
            "PriorityTests",
            DataAccessMethod.Sequential)]
        public void GetPriority_TestDataDriven()
        {
            // 1. Беремо дані з твоєї таблиці
            string operatorSymbol = TestContext.DataRow["Operator"].ToString();
            int expectedPriority = Convert.ToInt32(TestContext.DataRow["ExpectedPriority"]);

            // 2. Викликаємо метод через рефлексію
            MethodInfo getPriorityMethod = typeof(AnalaizerClass).GetMethod(
                "GetPriority",
                BindingFlags.NonPublic | BindingFlags.Static);

            Assert.IsNotNull(getPriorityMethod, "Метод GetPriority не знайдено!");

            object result = getPriorityMethod.Invoke(null, new object[] { operatorSymbol });
            byte actualPriority = Convert.ToByte(result);

            // 3. Порівнюємо результат
            Assert.AreEqual((byte)expectedPriority, actualPriority,
                $"Помилка для оператора '{operatorSymbol}'. Очікувалось: {expectedPriority}, Отримано: {actualPriority}");
        }
    }
}