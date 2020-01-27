using System;
using System.Globalization;
using System.Threading;

namespace CalculatorLogic
{
    /// <summary>
    /// //CODE_REVIEW
    /// </summary>
    public class Calculator
    {
        public ConsoleColor color = ConsoleColor.White;
        

        /// <summary>
        /// //CODE_REVIEW
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Sum(double a, double b)
        {
            var x = a + b;
            Console.ForegroundColor = color;

            Console.WriteLine("this is test");

            Thread.CurrentThread.CurrentUICulture =
                CultureInfo.GetCultureInfo("nb-NO");

            Console.WriteLine("this is test");

            CultureInfo enUs = new CultureInfo("fr-MU");
            Console.WriteLine($"The result is: {x}");
            return x;
        }
        /// <summary>
        /// //CODE_REVIEW
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Subtract(double a, double b)
        {
            var x = a - b;
            Console.ForegroundColor = color;
            Console.WriteLine($"The result is: {x}");
            return x;
        }
        /// <summary>
        /// //CODE_REVIEW
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Multiply(double a, double b)
        {
            var x = a * b;
            Console.ForegroundColor = color;
            Console.WriteLine($"The result is: {x}");
            return x;
        }

        /// <summary>
        /// //CODE_REVIEW
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double Divide(double a, double b)
        {
            var x = a / b;
            Console.ForegroundColor = color;
            Console.WriteLine($"The result is: {x}");
            return x;
        }
    }
}
