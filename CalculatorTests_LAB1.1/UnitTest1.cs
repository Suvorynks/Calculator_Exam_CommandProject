using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalaizerClassLibrary;

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
            // 1. Зчитування даних із таблиці MS SQL
            string operatorSymbol = TestContext.DataRow["Operator"].ToString();
            int expectedPriority = Convert.ToInt32(TestContext.DataRow["ExpectedPriority"]);

            // 2. Доступ до приватного методу через рефлексію
            MethodInfo getPriorityMethod = typeof(AnalaizerClass).GetMethod(
                "GetPriority",
                BindingFlags.NonPublic | BindingFlags.Static);

            Assert.IsNotNull(getPriorityMethod, "Метод GetPriority не знайдено!");

            // 3. Виклик методу та отримання результату
            object result = getPriorityMethod.Invoke(null, new object[] { operatorSymbol });
            byte actualPriority = Convert.ToByte(result);

            // 4. Перевірка результату
            Assert.AreEqual((byte)expectedPriority, actualPriority,
                $"Помилка для оператора '{operatorSymbol}'. Очікувалось: {expectedPriority}, Отримано: {actualPriority}");
        }
    }
}