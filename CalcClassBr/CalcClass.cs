using System;
using ErrorLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcClassBr
{
    public class CalcClass
    {
        /// <summary> 
        /// Функція складання числа а і b 
        /// </summary> 
        /// <param name="a">доданок</param> 
        /// <param name="b">доданок</param> 
        /// <returns>сума</returns>
        public static int Add(long a, long b)
        {
            _lastError = "";
            long res;
            if ((a <= int.MaxValue && a >= int.MinValue) && (b <= int.MaxValue && b >= int.MinValue))
                res = a + b;
            else
                {
                _lastError = ErrorsExpression.ERROR_06;
                throw new ArgumentOutOfRangeException(_lastError);
                }

            if ((res <= int.MaxValue && res >= int.MinValue))
                return (int)res;
            else
            {
                _lastError = ErrorsExpression.ERROR_06;
                throw new ArgumentOutOfRangeException(_lastError);
            }
        }
        /// <summary> 
        /// функція віднімання чисел а і b 
        /// </summary> 
        /// <param name="a">зменшуване</param> 
        /// <param name="b">від’ємне</param> 
        /// <returns>різниця</returns>
        public static int Sub(long a, long b)
        {
            _lastError = "";
            long res;
            if ((a <= int.MaxValue && a >= int.MinValue) && (b <= int.MaxValue && b >= int.MinValue))
                res = a - b;
            else
            {
                _lastError = ErrorsExpression.ERROR_06;
                throw new ArgumentOutOfRangeException(_lastError);
            }

            if ((res <= int.MaxValue && res >= int.MinValue))
                return (int)res;
            else
            {
                _lastError = ErrorsExpression.ERROR_06;
                throw new ArgumentOutOfRangeException(_lastError);
            }
        }
        /// <summary> 
        /// функція множення чисел а і b 
        /// </summary> 
        /// <param name="a">множник</param> 
        /// <param name="b">множник</param> 
        /// <returns>добуток</returns>
        public static int Mult(long a, long b)
        {
            _lastError = "";
            long res;
            if ((a <= int.MaxValue && a >= int.MinValue) && (b <= int.MaxValue && b >= int.MinValue))
                res = a * b;
            else
            {
                _lastError = ErrorsExpression.ERROR_06;
                throw new ArgumentOutOfRangeException(_lastError);
            }

            if ((res <= int.MaxValue && res >= int.MinValue))
                return (int)res;
            else
            {
                _lastError = ErrorsExpression.ERROR_06;
                throw new ArgumentOutOfRangeException(_lastError);
            }
        }
        /// <summary> 
        /// функція знаходження частки 
        /// </summary> 
        /// <param name="a">ділене</param> 
        /// <param name="b">дільник</param> 
        /// <returns>частка</returns> 
        public static int Div(long a, long b)
        {
            _lastError = "";
            long res;
            if ((a <= int.MaxValue && a >= int.MinValue) && (b <= int.MaxValue && b >= int.MinValue))
                if (b != 0)
                    res = a / b;
                else
                {
                    _lastError = ErrorsExpression.ERROR_09;
                    throw new DivideByZeroException(_lastError);
                }
            else
            {
                _lastError = ErrorsExpression.ERROR_06;
                throw new ArgumentOutOfRangeException(_lastError);
            }

            if ((res <= int.MaxValue && res >= int.MinValue))
                return (int)res;
            else
            {
                _lastError = ErrorsExpression.ERROR_06;
                throw new ArgumentOutOfRangeException(_lastError);
            }


        }
        /// <summary> 
        /// функція ділення по модулю 
        /// </summary> 
        /// <param name="a">ділене</param> 
        /// <param name="b">дільник</param> 
        /// <returns>остача</returns> 
        public static int Mod(long a, long b)
        {
            _lastError = "";
            long res;
            if ((a <= int.MaxValue && a >= int.MinValue) && (b <= int.MaxValue && b >= int.MinValue))
                if (b != 0)
                    res = a % b;
                else
                {
                    _lastError = ErrorsExpression.ERROR_09;
                    throw new DivideByZeroException(_lastError);
                }
            else
            {
                _lastError = ErrorsExpression.ERROR_06;
                throw new ArgumentOutOfRangeException(_lastError);
            }

            if ((res <= int.MaxValue && res >= int.MinValue))
                return (int)res;
            else
            {
                _lastError = ErrorsExpression.ERROR_06;
                throw new ArgumentOutOfRangeException(_lastError);
            }
        }

        /// <summary> 
        /// унарний плюс  
        /// </summary> 
        /// <param name="a"></param> 
        /// <returns></returns> 
        public static int ABS(long a)
        {
            _lastError = "";
            long res;
            if (a <= int.MaxValue && a >= int.MinValue)
            {
                res = a;
                return (int)res;
            }
            else
            {
                _lastError = ErrorsExpression.ERROR_06;
                throw new ArgumentOutOfRangeException(_lastError);
            }
        }

        /// <summary> 
        /// унарний мінус  
        /// </summary> 
        /// <param name="a"></param> 
        /// <returns></returns> 
        public static int IABS(long a)
        {
            _lastError = "";
            long res;
            if (a <= int.MaxValue && a >= int.MinValue)
            {
                res = a * -1;
                return (int)res;
            }
            else
            {
                _lastError = ErrorsExpression.ERROR_06;
                throw new ArgumentOutOfRangeException(_lastError);
            }
        }

        /// <summary> 
        /// Останнє повідомлення про помилку. 
        /// Поле і властивість для нього 
        /// </summary> 
        private static string _lastError = "";
        public static string lastError
        {
            get { return _lastError; }
            //Job well done!
        }
    }
   
}
