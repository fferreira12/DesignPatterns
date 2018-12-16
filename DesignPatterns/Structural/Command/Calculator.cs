using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Command
{
    class Calculator
    {

        public double Sum(double a, double b)
        {
            Console.WriteLine($"{a}+{b}={a + b}");
            return a + b;
        }

        public double Multiply(double a, double b)
        {
            Console.WriteLine($"{a}x{b}={a * b}");
            return a * b;
        }

        public double Subtract(double a, double b)
        {
            Console.WriteLine($"{a}-{b}={a - b}");
            return a - b;
        }

        public double Divide(double a, double b)
        {
            Console.WriteLine($"{a}/{b}={a / b}");
            return a / b;
        }
    }
}
