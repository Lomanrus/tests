using System;
using fraction;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_12and13_56()
        {
            //arrange
            Fraction a = new Fraction(1, 2);
            Fraction b = new Fraction(1, 3);
            Fraction expected = new Fraction(5, 6);
            //act
            Fraction actual = Fraction.Add(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Sub_12and13_16()
        {
            //arrange
            Fraction a = new Fraction(1, 2);
            Fraction b = new Fraction(1, 3);
            Fraction expected = new Fraction(1, 6);
            //act
            Fraction actual = Fraction.Sub(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void SetFormat_24_12()
        {
            //arrange
            Fraction a = new Fraction(2, 4);
            Fraction expected = new Fraction(1, 2);
            //act
            Fraction actual = Fraction.SetFormat(a);
            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetDouble_12()
        {
            //arrange
            Fraction a = new Fraction(1, 2);
            double expected = 0.5;


            //act
            double actual = Fraction.GetDouble(a);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Mul_12and12_14()
        {
            //arrange
            Fraction a = new Fraction(1,2);
            Fraction b = new Fraction(1,2);
            Fraction expected = new Fraction(1,4);
            //act
            Fraction actual = Fraction.Mul(a,b);
            //assert
            Assert.AreEqual(expected,actual);
        }
    }
}
