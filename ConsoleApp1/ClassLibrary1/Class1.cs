using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Calculator
    {
        public static string quadraticEquation(double coeffA, double coeffB, double coeffC, string result)
        {

            double Discriminant = coeffB * coeffB - 4 * coeffA * coeffC;

            if (Discriminant < 0)
            {
                result = "Discriminant < 0.  Then there are no real roots.";
            }
            else
            {
                double x1, x2;
                if (Discriminant == 0)
                {
                    x1 = x2 = -(coeffB / 2 * coeffC);
                }
                else
                {
                    double sqrtDiscriminant = (double)System.Math.Sqrt(Discriminant);
                    x1 = (-coeffB + sqrtDiscriminant) / (2 * coeffA);
                    x2 = (-coeffB - sqrtDiscriminant) / (2 * coeffA);
                }

                result = "Discriminant = " + Discriminant.ToString() + "; Roots: x1 = " + x1.ToString() + "; x2 = " + x2.ToString();
                Console.WriteLine($"{coeffA}*x^2 + {coeffB} * x + {coeffC} = {coeffA}*(x - {x1}) *(x-{x2})");
            }

            return result;
        }

        public static string nQuadraticEquation(double coeffA, double coeffB, double coeffC, string result)
        {
            double x1, x2;
            if (coeffB == 0 & coeffC == 0)
            {
                result = "Root: x = 0";
            }
            else if (coeffB == 0 & coeffC != 0)
            {

                if ((-coeffC / coeffA) > 0)
                {
                    x1 = (double)System.Math.Sqrt(-coeffC / coeffA);
                    x2 = -(double)System.Math.Sqrt(-coeffC / coeffA);
                    result = "Roots: x1 = " + x1.ToString() + " x2 = " + x2.ToString();
                }
                else
                {
                    result = "Then there are no real roots.";
                }
            }
            else if (coeffB != 0 & coeffC == 0)
            {
                x1 = 0;
                x2 = -coeffB / coeffA;
                result = "Roots: x1 = " + x1.ToString() + " x2 = " + x2.ToString();
            }
            return result;
        }

    }
}
