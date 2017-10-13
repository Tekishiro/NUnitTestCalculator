using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UnitDemo
{
    public class Class1
    {
        [SetUp]
        public void PreCondition()
        {
            Console.WriteLine("Pre-condition");
        }

        #region SumTests
        [Test]
        public static void SumTestBase()
        {
            Console.WriteLine("Sum base test");
            double actual = Calculator.Sum(2, 3);
            Assert.AreEqual(5, actual);
        }

        [Test]
        public static void SumTestOneNegated()
        {
            Console.WriteLine("Sum test with one of args below zero");
            double actual = Calculator.Sum(3, -2);
            Assert.AreEqual(1, actual);
        }

        [Test]
        public static void SumTestBothNegated()
        {
            Console.WriteLine("Sum test with both of args below zero");
            double actual = Calculator.Sum(-1, -2);
            Assert.AreEqual(-3, actual);
        }

        [Test]
        public static void SumTestReturnZero()
        {
            Console.WriteLine("Sum test that should return zero");
            double actual = Calculator.Sum(2, -2);
            Assert.AreEqual(0, actual);
        }

        [Test]
        public static void SumTestZero()
        {
            Console.WriteLine("Sum test with both args equals zero");
            double actual = Calculator.Sum(0, 0);
            Assert.AreEqual(0, actual);
        }
        #endregion

        #region MinusTests
        [Test]
        public static void MinusTestBase()
        {
            Console.WriteLine("Minus base test");
            double actual = Calculator.Minus(5, 3);
            Assert.AreEqual(2, actual);
        }

        [Test]
        public static void MinusTestOneNegated()
        {
            Console.WriteLine("Minus test with one of args below zero");
            double actual = Calculator.Minus(5, -3);
            Assert.AreEqual(8, actual);
        }

        [Test]
        public static void MinusTestBothNegated()
        {
            Console.WriteLine("Minus test with both of args negated");
            double actual = Calculator.Minus(-5, -3);
            Assert.AreEqual(-2, actual);
        }

        [Test]
        public static void MinusTestFractional()
        {
            Console.WriteLine("Minus test with fractional args");
            double actual = Calculator.Minus(1, 0.5);
            Assert.AreEqual(0.5, actual);
        }

        [Test]
        public static void MinusTestZero()
        {
            Console.WriteLine("Minus test with one of args is zero");
            double actual = Calculator.Minus(5, 3);
            Assert.AreEqual(2, actual);
        }
        #endregion

        #region MultTests
        [Test]
        public static void MultTestBase()
        {
            Console.WriteLine("Mult base test");
            double actual = Calculator.Mult(5, 3);
            Assert.AreEqual(15, actual);
        }

        [Test]
        public static void MultTestOneNegated()
        {
            Console.WriteLine("Mult test with one of args below zero");
            double actual = Calculator.Mult(5, -3);
            Assert.AreEqual(-15, actual);
        }

        [Test]
        public static void MultTestBothNegated()
        {
            Console.WriteLine("Mult test with both of args below zero");
            double actual = Calculator.Mult(-5, -3);
            Assert.AreEqual(15, actual);
        }

        [Test]
        public static void MultTestZero()
        {
            Console.WriteLine("Mult test");
            double actual = Calculator.Mult(5, 0);
            Assert.AreEqual(0, actual);
        }

        [Test]
        public static void MultTestFractional()
        {
            Console.WriteLine("Mult test with fractional args");
            double actual = Calculator.Mult(5, 0.5);
            Assert.AreEqual(2.5, actual);
        }
        #endregion

        #region DivTests
        [Test]
        public static void DivTestBase()
        {
            Console.WriteLine("Div base test");
            double actual = Calculator.Div(10, 5);
            Assert.AreEqual(2, actual);
        }

        [Test]
        public static void DivTestOneNegated()
        {
            Console.WriteLine("Div test with one of args below zero");
            double actual = Calculator.Div(-10, 5);
            Assert.AreEqual(-2, actual);
        }

        [Test]
        public static void DivTestBothNegated()
        {
            Console.WriteLine("Div test with both of args below zero");
            double actual = Calculator.Div(-10, -5);
            Assert.AreEqual(2, actual);
        }

        [Test]
        public static void DivTestInfinity()
        {
            Console.WriteLine("Div test with number divided by zero - should return Infinity");
            double actual = Calculator.Div(10, 0);
            Assert.AreEqual(Double.PositiveInfinity, actual);
        }

        [Test]
        public static void DivTestNaN()
        {
            Console.WriteLine("Div test with zero divided by zero - should return NaN");
            Assert.IsNaN(Calculator.Div(0, 0));
        }
        #endregion

        [TearDown]
        public void PostCondition()
        {
            Console.WriteLine("Post-condition");
        }
    }


}
