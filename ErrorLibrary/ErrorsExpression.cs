using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorLibrary
{
    public static class ErrorsExpression
    {
        public const string ERROR_01 = "Error 01 at <i> — Неправильна структура в дужках, помилка на <i> символі.";
        public const string ERROR_02 = "Error 02 at <i> — Невідомий оператор на <i> символі.";
        public const string ERROR_03 = "Error 03 — Невірна синтаксична конструкція вхідного виразу.";
        public const string ERROR_04 = "Error 04 at <i> — Два підряд оператори на <i> символі.";
        public const string ERROR_05 = "Error 05 — Незавершений вираз.";
        public const string ERROR_06 = "Error 06 — Дуже мале, або дуже велике значення числа для int. Числа повинні бути в межах від -2 147 483 648 до 2 147 483 647.";
        public const string ERROR_07 = "Error 07 — Дуже довгий вираз. Максмальная довжина — 65536 символів.";
        public const string ERROR_08 = "Error 08 — Сумарна кількість чисел і операторів перевищує 30.";
        public const string ERROR_09 = "Error 09 – Помилка ділення на 0.";

        public static string GetFullStringError(string errorMessage, int position)
        {
            return errorMessage.Replace("<i>", $"<{position}>");
        }
    }
}
