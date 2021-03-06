﻿using System;
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

        public void Clear()
        {
            Accumulator = 0.0;
        }
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


        public double Power(double exp)
        {
            Accumulator= Math.Pow(Accumulator, exp);
            return Accumulator;
        }

        public double Multiply(double multiplier)
        {
            Accumulator = Accumulator * multiplier;
            return Accumulator;
        }

        public double Divide(double divisor)
        {
            Accumulator = (Accumulator / divisor);
            return Accumulator;
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
