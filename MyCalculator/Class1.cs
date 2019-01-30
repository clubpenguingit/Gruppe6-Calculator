using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    public class Calculator
    {
        public Calculator() { }
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }

        public double Add(double addend)
        {
            Accumulator = addend + Accumulator;
            return Accumulator;
        }

        public double Subtract(double subtractor)
        {
            Accumulator = subtractor - Accumulator;
            return Accumulator;
        }
    }

}
