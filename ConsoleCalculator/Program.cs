using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using CalculatorLogic;

namespace ConsoleCalculator
{
    class Program
    {
        /// <summary>
        /// //CODE_REVIEW
        /// </summary>
        
        static void Main()
        {
            
            Console.Write("Type the operation you want to execute (sum, subtract, multiply, divide): ... ");
            var result = Console.ReadLine();

            Console.Write("Type the Color you want to show result (red, yellow, blue, white): ... ");
            var color_result = Console.ReadLine();

            Console.Write("Type a language for the messages(English, Spanish): ... ");
            var language_result = Console.ReadLine();

            Console.Write("Please type the first operand: ");
            var n1 = Console.ReadLine();

            Console.Write("Now, Please type the second operand: ");
            var n2 = Console.ReadLine();

            var calculator = new Calculator();

            if (color_result == "red")
            {
                calculator.color = ConsoleColor.Red;
            }
            else if(color_result == "yellow")
            {
                calculator.color = ConsoleColor.Yellow;
            }
            else if (color_result == "blue")
            {
                calculator.color = ConsoleColor.Blue;
            }
            else if (color_result == "white")
            {
                calculator.color = ConsoleColor.White;
            }
            else
            {
                calculator.color = ConsoleColor.White;
            }

            if (language_result == "English")
            {
                CultureInfo enUs = new CultureInfo("en-US");
            }
            else if (language_result == "Spanish")
            {
                CultureInfo enUs = new CultureInfo("es-ES");
            }


            //CODE_REVIEW
            if (result == "sum")
            {
               

               // Thread.CurrentThread.CurrentUICulture = new CultureInfo("it");
                calculator.Sum(Convert.ToDouble(n1), Convert.ToDouble(n2));
            }
            else
            {
                if (result == "subtract")
                {
                    calculator.Subtract(Convert.ToDouble(n1), Convert.ToDouble(n2));
                }
                else
                {
                    if (result == "multiply")
                    {
                        calculator.Multiply(Convert.ToDouble(n1), Convert.ToDouble(n2));
                    }
                    else
                    {
                        if (result == "divide")
                        {
                            calculator.Divide(Convert.ToDouble(n1), Convert.ToDouble(n2));
                        }
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
