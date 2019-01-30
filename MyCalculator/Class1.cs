using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    public class Calculator
    {
        public Calculator()
        {
            Accumulator = 0.0; //Accumulator is zero by default. 
        }

        public double Accumulator {  get; private set; }  //Accumulator property. Always holds return value of latest function call
        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return a * b;
        }

        public double Power(double x, double exp)
        {
            Accumulator = Math.Pow(x, exp);
            return Math.Pow(x, exp);
        }


        public double Power(double exp)
        {
            return Math.Pow(Accumulator, exp);
        }

        public double Multiply(double multiplier)
        {
            return Accumulator * multiplier;
        }

        public double Divide(double divisor)
        {
            return (Accumulator / divisor);
        }



        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException("YOU DONE FUCKED UP!!!");
            }

            return dividend / divisor;
        }
    }

}
