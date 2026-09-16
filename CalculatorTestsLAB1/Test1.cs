using AnalaizerClassLibrary;
using AnalizerClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Reflection;

namespace CalculatorTestsLAB1
{
    [TestClass]
    public class Test1
    {
        // Властивість для доступу до бази даних
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("System.Data.SqlClient",
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CalculatorTestDB;Integrated Security=True",
            "PriorityTests",
            DataAccessMethod.Sequential)]
        public void GetPriority_TestFromDB()
        {
            // 1. Беремо дані з поточного рядка бази
            string operatorSymbol = TestContext.DataRow["Operator"].ToString();
            int expectedPriority = Convert.ToInt32(TestContext.DataRow["ExpectedPriority"]);

            // 2. Знаходимо метод GetPriority через рефлексію
            MethodInfo getPriorityMethod = typeof(AnalaizerClass).GetMethod(
                "GetPriority",
                BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Public);

            Assert.IsNotNull(getPriorityMethod, "Метод GetPriority не знайдено!");

            // 3. Викликаємо метод 
            object result = getPriorityMethod.Invoke(null, new object[] { operatorSymbol });

            // 4. Конвертуємо результат у звичайне число
            int actualPriority = Convert.ToInt32(result);

            // 5. Порівнюємо результат з очікуваним (виправив опечатку тут!)
            Assert.AreEqual(expectedPriority, actualPriority,
                $"Помилка для оператора '{operatorSymbol}'.");
        }
    }
}