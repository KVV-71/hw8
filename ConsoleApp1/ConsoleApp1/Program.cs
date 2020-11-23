using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double coefficientA = 0;
                double coefficientB = 0;
                double coefficientC = 0;

                Console.WriteLine("quadratic equation: ax2 + bx + c = 0");
                Console.Write("a = ");
                while (!double.TryParse(Console.ReadLine(), out coefficientA))
                {
                    Console.WriteLine("Input Error! Insert number");
                }

                Console.Write("b = ");
                while (!double.TryParse(Console.ReadLine(), out coefficientB))
                {
                    Console.WriteLine("Input Error! Insert number");
                }

                Console.Write("c = ");
                while (!double.TryParse(Console.ReadLine(), out coefficientC))
                {
                    Console.WriteLine("Input Error! Insert number");
                }

                string result = string.Empty;

                if (coefficientA == 0)
                {
                    result = "This is not a quadratic equation";
                }
                else
                {
                    if (coefficientB == 0 || coefficientC == 0)
                    {
                        result = Calculator.nQuadraticEquation(coefficientA, coefficientB, coefficientC, result);
                    }
                    else
                    {
                        result = Calculator.quadraticEquation(coefficientA, coefficientB, coefficientC, result);
                    }
                }
                Console.WriteLine(result);

                Console.ReadKey();
            }
        }
    }
}