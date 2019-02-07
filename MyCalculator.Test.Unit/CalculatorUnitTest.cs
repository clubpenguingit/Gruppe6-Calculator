using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MyCalculator.Test.Unit
{
    [TestFixture]
    public class CalculatorUnitTest
    {
        [Test]
        public void Add_Add4And2_Returns6()
        {
            var uut = new Calculator();
            Assert.That(uut.Add(2,4), Is.EqualTo(6));
        }

        [Test]
        public void Add_AddMinus2AndMinus2_ReturnsMinus4()
        {
            var uut = new Calculator();
            Assert.That(uut.Add(-2,-2), Is.EqualTo(-4));
        }

        [Test]
        public void Add_AddMinus2And4_returns2()
        {
            var uut = new Calculator();
            Assert.That(uut.Add(-2,4), Is.EqualTo((2)));
        }

        [Test]
        public void Add_Add2and0_Returns2()
        {
            Calculator uut = new Calculator();
            Assert.That(uut.Add(2, 0), Is.EqualTo(2));
        }

        [TestCase(2,2,0)]
        [TestCase(-2,2,-4)]
        [TestCase(-2,-2,0)]
        public void Subtract_MultipleSubstracts_AllCorrect(double a,double b,double result)
        {
            var uut = new Calculator();
            Assert.That(uut.Subtract(a,b), Is.EqualTo(result));
        }

        //*** Multipy tests ***//
        [TestCase(2,2,4)] // 2 * 2 = 4
        [TestCase(0,1,0)] // 0 * 1 = 0
        [TestCase(-1,5,-5)] // -1 *5 = -5
        [TestCase(-2,-2,4)] // -2*-2 = 4
        public void Multiply_MultipleInputs_AllCorrect(double a, double b, double result)
        {
            Calculator uut = new Calculator();
            Assert.That(uut.Multiply(a, b), Is.EqualTo(result));
        }
        //*********************//

        //*** Power Tests ***//
        [TestCase(2, 3, 8)]     //2^3 = 8
        [TestCase(23,0,1)]      //23^0= 1
        [TestCase(2,-1,0.5)]    //2^-1= 0.5
        [TestCase(-2,2,4)]      //-2^2 = 4  (Inverts negative)
        [TestCase(-2,3,-8)]     //-2^3 =-8  (negative again) 
        [TestCase(0,100023,0)]
        public void Power_MultipleInputs_AllCorrect(double x, double exp, double result)
        {
            Calculator uut = new Calculator();
            Assert.That(uut.Power(x, exp), Is.EqualTo(result));
           
        }
        //*******************//

        //*** Overloaded Add ***//
        [TestCase(2, 2)]
        public void Overloaded_Addition_Test(double input, double result)
        {
            Calculator uut = new Calculator();
            Assert.That(uut.Add(input), Is.EqualTo(result));
        }
        //**********************//

        //*** Accumulator Tets***//
        [Test]
        public void Accumulator_ValueIsZeroUponNewCalculator_true()
        {
            Calculator calc = new Calculator();
            Assert.That(calc.Accumulator, Is.EqualTo(0.0));
        }

        [Test]
        public void Accumulator_Add2And2_AccumulatorHolds4()
        {
            var calc = new Calculator();
            calc.Add(2, 2);
            Assert.That(calc.Accumulator, Is.EqualTo(4));
        }

        [Test]
        public void Accumulator_Substract2From4_AccumulatorHolds2()
        {
            Calculator c = new Calculator();
            c.Subtract(4, 2);
            Assert.That(c.Accumulator, Is.EqualTo(2));
        }

        [Test]
        public void Accumulator_Multiply3and3_AccumulatorHolds9()
        {
            Calculator c = new Calculator();
            c.Add(3);
            c.Multiply(3);
            Assert.That(c.Accumulator, Is.EqualTo(9));
        }

        [Test]
        public void Accumulator_2ToPowerOf3_AccumulatorHolds8()
        {
            Calculator c = new Calculator();
            c.Add(2);
            c.Power(3);
            Assert.That(c.Accumulator, Is.EqualTo(8));
        }

        [Test]
        public void Accumulator_Multiply0and0_AccumulatorHolds0()
        {
            Calculator c = new Calculator();
            c.Add(0);
            c.Multiply(0);
            Assert.That(c.Accumulator, Is.EqualTo(0));
        }

        [Test]
        public void Accumulator_Multiply2and2_AccumulatorHolds8()
        {
            Calculator c = new Calculator();
            c.Add(2, 2);
            c.Multiply(2);
            Assert.That(c.Accumulator, Is.EqualTo(8));
        }

        [TestCase(1, 0, 1)]
        [TestCase(2, 2, 4)]
        [TestCase(0, 0, 1)]
        public void Accumulator_PowerTests(double a, double b, double result)
        {
            Calculator c = new Calculator();
            c.Add(a);
            c.Power(b);
            Assert.That(c.Accumulator, Is.EqualTo(result));
        }

        [TestCase(2, 2, 1)]
        [TestCase(-2, 2, -1)]
        [TestCase(3, 2, 1.5)]
        public void Accumulator_DivideTests(double a, double b, double result)
        {
            Calculator c = new Calculator();
            c.Add(a);
            c.Divide(b);
            Assert.That(c.Accumulator, Is.EqualTo(result));
        }

        //*** TEST AF DIVISION ***///
        [TestCase(1,2,0.5)]
        [TestCase(-2,1,-2)]
        [TestCase(3,-1,-3)]
        [TestCase(0,3,0)]
        public void Division_MultipleInputs_AllCorrect(double a, double b, double result)
        {
            Calculator uut = new Calculator();
            Assert.That(uut.Divide(a,b), Is.EqualTo(result));
        }

        //*** DIVISION EXCEPTION TEST ***//
        [Test]
        public void Division_DivideByZero_ExceptionExpected()
        {
            Calculator uut = new Calculator();

            Assert.That(() => uut.Divide(3,0), Throws.TypeOf<DivideByZeroException>());
           
        }
        //*** Overloaded Sub ***//
        [TestCase(2, 2)]
        public void Overloaded_Subtraction_Test(double input, double result)
        {
            Calculator uut = new Calculator();
            Assert.That(uut.Subtract(input), Is.EqualTo(result));
        }
        //**********************//


        [TestCase(0)]
        [TestCase(1)]
        [TestCase(-1)]
        public void Clear_AccumulatorGetsClearedNoMatterPreviousVal_AlwaysHolds0(double input)
        {
            var calc = new Calculator();
            calc.Add(0, input); //Put input in Accumulator
            calc.Clear();           //Clear Accumulator = 0
            Assert.That(calc.Accumulator, Is.EqualTo(0));
        }
    }
}
