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
        public void Add_AddMinus2And4_returns2()
        {
            var uut = new Calculator();
            Assert.That(uut.Add(-2,4), Is.EqualTo((2)));
        }

        [Test]
        public void Subtract_Subtract2From4_Return2()
        {
            var uut = new Calculator();
            Assert.That(uut.Subtract(4,2), Is.EqualTo(2));
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


    }
}
