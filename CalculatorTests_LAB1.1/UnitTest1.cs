using AnalaizerClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Reflection;

namespace CalculatorTestsLAB1
{
    [TestClass]
    public class PriorityTestsClass
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("System.Data.SqlClient",
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CalculatorTestsLAB1;Integrated Security=True",
            "PriorityTests",
            DataAccessMethod.Sequential)]
        public void GetPriority_TestDataDriven()
        {
           
            string operatorSymbol = TestContext.DataRow["Operator"].ToString();
            int expectedPriority = Convert.ToInt32(TestContext.DataRow["ExpectedPriority"]);

            
            MethodInfo getPriorityMethod = typeof(AnalaizerClass).GetMethod(
                "GetPriority",
                BindingFlags.NonPublic | BindingFlags.Static);

            Assert.IsNotNull(getPriorityMethod, "Метод GetPriority не знайдено!");

            
            object result = getPriorityMethod.Invoke(null, new object[] { operatorSymbol });
            byte actualPriority = Convert.ToByte(result);

           
            Assert.AreEqual((byte)expectedPriority, actualPriority,
                $"Помилка для оператора '{operatorSymbol}'. Очікувалось: {expectedPriority}, Отримано: {actualPriority}");
        }

       
        public static bool ValidateExpressionRequirements(string expression, out string errorMessage)
        {
            errorMessage = "";

            // 4.3.7. Максимальна довжина виразу – 65535 символів
            if (expression.Length > 65535)
            {
                errorMessage = "Error: Довжина виразу перевищена.";
                return false;
            }

            // 4.3.6. Лише круглі дужки
            if (expression.Contains("{") || expression.Contains("}") || expression.Contains("[") || expression.Contains("]"))
            {
                errorMessage = "Error: Дозволяються лише дужки вигляду «(» і «)».";
                return false;
            }

            // 4.3.2. Максимальна глибина вкладеності дужок – 3
            int depth = 0;
            foreach (char c in expression)
            {
                if (c == '(') depth++;
                else if (c == ')') depth--;

                if (depth > 3)
                {
                    errorMessage = "Error: Глибина вкладеності дужок перевищує 3.";
                    return false;
                }
            }

            // 4.3.1. Максимальне сумарне число операторів і чисел – 30
            string[] numbers = expression.Split(new char[] { '+', '-', '*', '/', 'm', 'p', '(', ')', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int operatorsCount = 0;
            foreach (char c in expression)
            {
                if ("+-*/mp".Contains(c)) operatorsCount++;
            }
            if (expression.Contains("mod"))
            {
                operatorsCount += 1; 
            }

            if ((numbers.Length + operatorsCount) > 30)
            {
                errorMessage = "Error: Число операторів і чисел перевищує 30.";
                return false;
            }

            return true;
        }

        // Метод форматування (заміна унарних мінусів/плюсів, прибирання пробілів)
        public static string FormatExpression(string expression)
        {
            // 4.3.5. Прибираємо будь-яку кількість пропусків
            string formatted = expression.Replace(" ", "");

            // 4.3.4. Операція залишку — «mod» (у коді C# це %)
            formatted = formatted.Replace("mod", "%");

            // 4.3.3. Унарний мінус — «m», унарний плюс — «p»
            if (formatted.StartsWith("-")) formatted = "m" + formatted.Substring(1);
            if (formatted.StartsWith("+")) formatted = "p" + formatted.Substring(1);

            formatted = formatted.Replace("(-", "(m");
            formatted = formatted.Replace("(+", "(p");

            return formatted;
        }

       
        [TestMethod]
        public void Test_AdditionalRequirements_4_3()
        {
            // 1. Перевіряємо глибину дужок (не більше 3)
            bool isValid = ValidateExpressionRequirements("(((5+2)*3)-1)", out string err);
            Assert.IsTrue(isValid, "Тест впав: Має пропускати до 3 дужок");

            bool isInvalid = ValidateExpressionRequirements("((((5+2))))", out string err2);
            Assert.IsFalse(isInvalid, "Тест впав: Має блокувати 4 і більше дужок");

            // 2. Перевіряємо форматування (пробіли, унарні мінуси, mod)
            string rawExpression = " - 5 + ( - 3 ) mod 2"; 
            string formatted = FormatExpression(rawExpression);

          
            Assert.AreEqual("m5+(m3)%2", formatted, "Тест впав: Форматування унарних операторів та пробілів працює неправильно");
        }
    }
}