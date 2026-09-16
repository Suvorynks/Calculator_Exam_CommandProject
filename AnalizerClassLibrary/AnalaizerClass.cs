using CalcClassBr;
using ErrorLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalaizerClassLibrary
{

    public static class AnalaizerClass
    {
        private const char SYMBOL_CLOSE_BRACKET = ')';
        private const char SYMBOL_OPEN_BRACKET = '(';
        private const char SYMBOL_OPERATOR_ADD = '+';
        private const char SYMBOL_OPERATOR_SUB = '-';
        private const char SYMBOL_OPERATOR_DIV = '/';
        private const char SYMBOL_OPERATOR_MUL = '*';
        private const char SYMBOL_OPERATOR_MOD = '%';
        private const char SYMBOL_UNARY_PLUS = 'p';
        private const char SYMBOL_UNARY_MINUS = 'm';


        private static readonly char[] _operators = new char[]  // бінарні операції
            {
                SYMBOL_OPERATOR_ADD,
                SYMBOL_OPERATOR_SUB,
                SYMBOL_OPERATOR_MUL,
                SYMBOL_OPERATOR_DIV,
                SYMBOL_OPERATOR_MOD
            };

        private static readonly char[] _unary_operators = new char[]  // унарні операції
            {
                SYMBOL_UNARY_MINUS,
                SYMBOL_UNARY_PLUS
            };

        private static readonly char[] _brackets = new char[]  // дужки для розділу виразів
            {
                SYMBOL_OPEN_BRACKET,
                SYMBOL_CLOSE_BRACKET
            };

        /// <summary> 
        /// максимальна глибина вкладеності
        /// </summary> 
        private const int MAX_DEPTH_BRACKET = 3;

        /// <summary> 
        /// максимальна довжина виразу (символів)
        /// </summary> 
        private const int MAX_LENGHT_EXPRESSION = 65536;

        /// <summary> 
        /// максимальна кількість операторів та чисел у виразі
        /// </summary> 
        private const int MAX_COUNT_OPERANDS = 30;


        /// <summary> 
        /// позиція виразу, на якій знайдена синтаксична помилка 
        /// (у випадку відловлення на рівні виконання - не визначається) 
        /// </summary>     

        private static int erposition = 0;

        /// <summary>
        /// Вхідний вираз
        /// </summary>        
        public static string expression = "";

        /// <summary>
        /// Показує, чи є необхідність у виведенні повідомлень про помилки.
        /// У разі консольного запуску програми це значення - false.
        /// </summary>
        public static bool ShowMessage = false;


        /// <summary>
        /// Перевірка коректності структури в дужках вхідного виразу
        /// </summary>
        /// <returns> true - якщо все нормально, false - якщо  є помилка </returns>
        /// метод біжить по вхідному виразу, символ за символом аналізуючи його, і рахуючи кількість дужок.
        /// У разі виникнення помилки повертає false, а в erposition записує позицію, на якій виникла помилка.
        public static bool CheckCurrency()
        {
            erposition = 0;

            Stack<int> openBracket = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == SYMBOL_OPEN_BRACKET)
                {
                    openBracket.Push(i);

                    if (openBracket.Count > MAX_DEPTH_BRACKET)
                    {
                        erposition = i;
                        if (ShowMessage)
                            MessageBox.Show
                                ($"expression: '{expression}'\nerposition: {erposition}\nError in expression: Maximum depth bracket {MAX_DEPTH_BRACKET}",
                                 "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    if (expression[i] == ')')
                    {
                        if (openBracket.Count == 0) // варіант, при якому закриваюча дужка, використана без відкриваючої дужки                                                    
                        {
                            erposition = i;
                            if (ShowMessage)
                                MessageBox.Show
                                    ($"expression: '{expression}'\nerposition: {erposition}\nError in expression: '{SYMBOL_CLOSE_BRACKET}' used without '{SYMBOL_OPEN_BRACKET}'",
                                     "Error",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                            return false;
                        }
                        else
                            openBracket.Pop();
                    }
                }
            }

            if (openBracket.Count > 0) // якщо кількість выдкриваючих дужок, быльше кількості закриваючих
            {
                erposition = openBracket.Peek();
                if (ShowMessage)
                    MessageBox.Show
                        ($"expression: '{expression}'\nerposition: {erposition}\nError in expression: '{SYMBOL_OPEN_BRACKET}' used without '{SYMBOL_CLOSE_BRACKET}'",
                         "Error",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        ///<summary>
        /// Форматує вхідний вираз, виставляючи між операторами пропуски і видаляючи зайві, 
        /// а також знаходить нерозпізнані оператори, стежить за кінцем рядка 
        /// а також знаходить помилки в кінці рядка 
        /// </summary>
        ///<returns> кінцевий рядок або повідомлення про помилку, що починаються з спец. символу &</returns>
        public static string Format()
        {
            expression = expression.Replace(" ", "");    // видаляэмо всі пробіли у виразі


            if (expression.Length > MAX_LENGHT_EXPRESSION)
                return "&" + ErrorsExpression.ERROR_07;

            if (expression == "") return "";

            for (int i = 0; i < expression.Length; i++)
            {
                char currentSymbol = expression[i];

                // перевірка на невідомий символа оператора
                if (char.IsDigit(currentSymbol) ||
                    _operators.Contains(currentSymbol) ||
                    _brackets.Contains(currentSymbol) ||
                    _unary_operators.Contains(currentSymbol))
                    continue;

                return "&" + ErrorsExpression.GetFullStringError(ErrorsExpression.ERROR_02, i);
            }

            char startSymbol = expression[0];
            // перевірка на невірний початок виразу
            if (!char.IsDigit(startSymbol) &&
                startSymbol != SYMBOL_OPEN_BRACKET &&
                startSymbol != SYMBOL_UNARY_MINUS &&
                startSymbol != SYMBOL_UNARY_PLUS)
                return "&" + ErrorsExpression.ERROR_03;


            char endSymbol = expression[expression.Length - 1];
            // перевірка на закінчення всього виразу
            if (!char.IsDigit(endSymbol) &&
                endSymbol != SYMBOL_CLOSE_BRACKET)
                return "&" + ErrorsExpression.ERROR_05;


            for (int i = 0; i < expression.Length; i++)
            {
                char currentSymbol = expression[i];

                // проверка следующего символе после цифры
                if (char.IsDigit(currentSymbol))
                {
                    if (i < expression.Length - 1)
                    {
                        char nextSymbol = expression[i + 1];
                        if (nextSymbol == SYMBOL_OPEN_BRACKET || nextSymbol == SYMBOL_UNARY_MINUS || nextSymbol == SYMBOL_UNARY_PLUS)
                        {
                            return "&" + ErrorsExpression.GetFullStringError(ErrorsExpression.ERROR_01, i + 1);
                        }
                    }
                }


                // перевірка на два оператори підряд            
                if (_operators.Contains(currentSymbol))
                {
                    if (i < expression.Length - 1)
                    {
                        char nextSymbol = expression[i + 1];
                        if (_operators.Contains(nextSymbol))
                            return "&" + ErrorsExpression.GetFullStringError(ErrorsExpression.ERROR_04, i + 1);

                        if (!char.IsDigit(nextSymbol) && nextSymbol != SYMBOL_OPEN_BRACKET && nextSymbol != SYMBOL_UNARY_MINUS && nextSymbol != SYMBOL_UNARY_PLUS)
                            return "&" + ErrorsExpression.ERROR_03;
                    }
                }

                // перевірка на сивол після відкриваючої дужки
                if (currentSymbol == SYMBOL_OPEN_BRACKET)
                {
                    if (i < expression.Length - 1)
                    {
                        char nextSymbol = expression[i + 1];
                        if (nextSymbol == SYMBOL_CLOSE_BRACKET || _operators.Contains(nextSymbol))
                            return "&" + ErrorsExpression.ERROR_03;
                    }
                }

                // перевірка на символ після закриваючої дужки
                if (currentSymbol == SYMBOL_CLOSE_BRACKET)
                {
                    if (i < expression.Length - 1)
                    {
                        char nextSymbol = expression[i + 1];
                        if (!_operators.Contains(nextSymbol) && nextSymbol != SYMBOL_CLOSE_BRACKET)
                            return "&" + ErrorsExpression.ERROR_03;
                    }
                }

                // перевірка на сиволи після унарного оператора
                if (_unary_operators.Contains(currentSymbol))
                {
                    if (i < expression.Length - 1)
                    {
                        char nextSymbol = expression[i + 1];
                        if (nextSymbol == SYMBOL_CLOSE_BRACKET || _unary_operators.Contains(nextSymbol) || _operators.Contains(nextSymbol))
                            return "&" + ErrorsExpression.ERROR_03;
                    }
                    else
                        return "&" + ErrorsExpression.ERROR_05;
                }

            }

            return expression;

        }


        /// <summary>
        /// метод визначає чи є стрічка оператором 
        /// </summary> 
        /// <param name="c"></param>
        /// <returns> true - якщо, сивол э оператором, false - якщо сивол не э оператором </returns>        
        private static bool IsOperator(string s)
        {
            if (s.Length == 1)
            {
                char c = s[0];
                if (_operators.Contains(c) || _brackets.Contains(c) || _unary_operators.Contains(c))
                    return true;
            }

            return false;
        }

        /// <summary>
        /// метод визначає чи є символ роздилителем 
        /// </summary>
        /// <param name="c"></param>
        /// <returns> true - символ є пробілом, інакше false</returns>        
        private static bool IsDelimeter(char c)
        {
            return (c == ' ' ? true : false);
        }

        /// <summary>
        /// метод повертає пріоритет оператора 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>         
        static private byte GetPriority(string s)
        {


            switch (s)
            {
                case "(":
                case ")":
                    return 0;
                case "+":
                case "-":
                    return 1;
                case "*":
                case "/":
                    return 2;
                case "%":
                    return 3;
                case "m":
                case "p":
                    return 4;
                default:
                    return 5;
            }
        }

        public static IEnumerable<string> Separate(string input)
        {
            int pos = 0;
            while (pos < input.Length)
            {
                string s = string.Empty + input[pos];
                if (!_operators.Union(_brackets).Union(_unary_operators).Contains(input[pos]))
                //if (!_operators.Contains(input[pos]) || !_unary_operators.Contains(input[pos]))
                {
                    if (Char.IsDigit(input[pos]))
                        for (int i = pos + 1;
                            i < input.Length && Char.IsDigit(input[i]);
                            i++)
                            s += input[i];
                    else if (Char.IsLetter(input[pos]))
                        for (int i = pos + 1; i < input.Length &&
                            (Char.IsLetter(input[i]) || Char.IsDigit(input[i])); i++)
                            s += input[i];
                }
                yield return s;
                pos += s.Length;
            }
        }

        ///<summary>
        /// Формує  масив, в якому розташовуються оператори і символи 
        /// представлені в зворотному польському записі (без дужок)
        /// На  цьому ж етапі відшукується решта всіх помилок (див. код).
        /// По суті - це компіляція.
        /// </summary>
        /// <returns> массив зворотнього польського запису </returns>
        public static ArrayList CreateStack()
        {
            ArrayList result = new ArrayList();
            Stack<string> stack = new Stack<string>();

            foreach (string c in Separate(expression))
            {
                if (IsOperator(c))
                {
                    if (stack.Count > 0 && !c.Equals(SYMBOL_OPEN_BRACKET.ToString()))
                    {
                        if (c.Equals(SYMBOL_CLOSE_BRACKET.ToString()))
                        {
                            string s = stack.Pop();
                            while (s != SYMBOL_OPEN_BRACKET.ToString())
                            {
                                result.Add(s);
                                s = stack.Pop();
                            }
                        }
                        else
                            if (GetPriority(c) > GetPriority(stack.Peek()))
                            stack.Push(c);
                        else
                        {
                            while (stack.Count > 0 && GetPriority(c) <= GetPriority(stack.Peek()))
                                result.Add(stack.Pop());
                            stack.Push(c);
                        }
                    }
                    else
                        stack.Push(c);
                }
                else
                    result.Add(c);
            }
            if (stack.Count > 0)
                foreach (string c in stack)
                    result.Add(c);

            return result;

        }


        ///<summary>
        /// Обчислення зворотнього польського запису
        /// </summary>
        /// <returns> результат обчислень, або повідомлення про помилку </returns>
        public static string RunEstimate()
        {
            Stack<string> stack = new Stack<string>();
            Queue<string> queue = new Queue<string>();
            foreach (var item in CreateStack())
            {
                queue.Enqueue((string)item);
            }

            if (queue.Count == 1)
            {
                return queue.Dequeue();
            }
            else
            {
                if (queue.Count > MAX_COUNT_OPERANDS)
                    return "&" + ErrorsExpression.ERROR_08;
            }

            string str = queue.Dequeue();

            while (queue.Count >= 0)
            {
                if (!IsOperator(str))
                {
                    stack.Push(str);
                    str = queue.Dequeue();
                }
                else
                {
                    long res = 0;
                    try
                    {

                        switch (str)
                        {
                            case "+":
                                {
                                    long b = Convert.ToInt64(stack.Pop());
                                    long a = Convert.ToInt64(stack.Pop());
                                    res = CalcClass.Add(a, b);
                                    break;
                                }
                            case "-":
                                {
                                    long b = Convert.ToInt64(stack.Pop());
                                    long a = Convert.ToInt64(stack.Pop());
                                    res = CalcClass.Sub(a, b);
                                    break;
                                }
                            case "*":
                                {
                                    long b = Convert.ToInt64(stack.Pop());
                                    long a = Convert.ToInt64(stack.Pop());
                                    res = CalcClass.Mult(a, b);
                                    break;
                                }
                            case "/":
                                {
                                    long b = Convert.ToInt64(stack.Pop());
                                    long a = Convert.ToInt64(stack.Pop());
                                    res = CalcClass.Div(a, b);
                                    break;
                                }
                            case "%":
                                {
                                    long b = Convert.ToInt64(stack.Pop());
                                    long a = Convert.ToInt64(stack.Pop());
                                    res = CalcClass.Mod(a, b);
                                    break;
                                }
                            case "m":
                                {
                                    long a = Convert.ToInt64(stack.Pop());
                                    res = CalcClass.IABS(a);
                                    break;
                                }
                            case "p":
                                {
                                    long a = Convert.ToInt64(stack.Pop());
                                    res = CalcClass.ABS(a);
                                    break;
                                }
                        }
                    }

                    catch
                    {
                        return "&" + CalcClass.lastError;
                    }


                    stack.Push(res.ToString());
                    if (queue.Count > 0)
                        str = queue.Dequeue();
                    else
                        break;
                }
            }

            return stack.Pop();


        }

        private static string InsertSymbol(string input, char symbol, int position)
        {
            string res = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (i == position) res += symbol;
                else res += input[i];
            }
            return res;
        }

        public static string ReplaceUnaryPlusMinus(string input)
        {
            string res = input.Replace(" ", "");

            for (int i = 0; i < res.Length; i++)
            {
                char currentSymbol = res[i];
                if (currentSymbol == SYMBOL_OPERATOR_ADD)
                {
                    char previosSymbol = SYMBOL_OPERATOR_MUL;

                    if (i > 0) previosSymbol = res[i - 1];

                    if (i < res.Length - 1)
                    {
                        char nextSymbol = res[i + 1];
                        if ((nextSymbol == SYMBOL_OPEN_BRACKET || char.IsDigit(nextSymbol)) && (_operators.Contains(previosSymbol) || previosSymbol == SYMBOL_OPEN_BRACKET))
                            res = InsertSymbol(res, SYMBOL_UNARY_PLUS, i);
                    }
                }

                if (currentSymbol == SYMBOL_OPERATOR_SUB)
                {
                    char previosSymbol = SYMBOL_OPERATOR_MUL;

                    if (i > 0) previosSymbol = res[i - 1];

                    if (i < res.Length - 1)
                    {
                        char nextSymbol = res[i + 1];
                        if ((nextSymbol == SYMBOL_OPEN_BRACKET || char.IsDigit(nextSymbol)) && (_operators.Contains(previosSymbol) || previosSymbol == SYMBOL_OPEN_BRACKET))
                            res = InsertSymbol(res, SYMBOL_UNARY_MINUS, i);
                    }
                }
            }

            return res;
        }

        /// <summary>
        /// Метод, який організовує обчислення. 
        /// По черзі запускає CheckCorrncy, Format, CreateStack і RunEstimate
        /// </summary>
        /// <returns></returns>
        public static string Estimate()
        {
            if (!CheckCurrency())
                return "&" + ErrorsExpression.GetFullStringError(ErrorsExpression.ERROR_01, erposition);

            expression = ReplaceUnaryPlusMinus(expression);

            string format = Format();

            if (format == "") return "";

            if (format.StartsWith("&"))
                return format;


            return RunEstimate();

        }

    }
}

