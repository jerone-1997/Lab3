using System;
using System.Collections.Generic;
using System.Text;

/*ICT3101: Lab 3 changes
Prepared by: Jerone Poh
*/

namespace ICT3101_Calculator
{
    public class Calculator
    {
        public Calculator() { }
        public double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value
            // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = Add(num1, num2);
                    break;
                case "s":
                    result = Subtract(num1, num2);
                    break;
                case "m":
                    result = Multiply(num1, num2);
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    result = Divide(num1, num2);
                    break;
                case "f":
                    // Q16b: Factorial function of first number entered
                    result = Factorial(num1);
                    break;
                case "aot":
                    // Q17a: Area of triangle
                    result = AreaOfTriangle(num1, num2);
                    break;
                case "aoc":
                    // Q17b: Area of circle
                    result = AreaOfCircle(num1);
                    break;
                case "ufa":
                    // Q18a: Unknown Function A
                    result = UnknownFunctionA(num1, num2);
                    break;
                case "ufb":
                    // Q18b: Unknown Function B
                    result = UnknownFunctionB(num1, num2);
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }
        public double Add(double num1, double num2)
        {
            return (num1 + num2);
        }
        // Q14
        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }
        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }
        public double Divide(double num1, double num2)
        {
            // Q14: No exception handling
            //return (num1 / num2);

            // Q15: throw new argument exception for divide
            if (num1 == 0 || num2 == 0)
            {
                throw new ArgumentException();
            }
            return (num1 / num2);
        }
        // Q16: Factorial function
        public double Factorial(double num1)
        {
            double result = 1;
            if (num1 < 0)
            {
                throw new ArgumentException();
            } else
            {
                while (num1 != 0)
                {
                    result = result * num1;
                    num1--;
                }
                if (result > Int32.MaxValue)
                {
                    throw new ArgumentException();
                }
            }
            return result;
        }
        // Q17a: Area of triangle function
        public double AreaOfTriangle(double num1, double num2)
        {
            if (num1 <= 0 || num2 <= 0)
            {
                throw new ArgumentException();
            }
            return (0.5 * num1 * num2);
        }
        // Q17b: Area of circle function
        public double AreaOfCircle(double num1)
        {
            if (num1 <= 0)
            {
                throw new ArgumentException();
            }
            return (Math.PI * num1 * num1);
        }
        // Q18a: Unknown Function A
        public double UnknownFunctionA(double num1, double num2)
        {
            return Divide(Factorial(num1), Factorial(Subtract(num1, num2)));
        }
        // Q18b: Unknown Function B
        public double UnknownFunctionB(double num1, double num2)
        {
            return Divide(Factorial(num1), Multiply(Factorial(num2), Factorial(Subtract(num1, num2))));
        }
    }

}
