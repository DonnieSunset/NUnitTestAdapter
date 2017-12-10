using MyLibrary;
using NUnit.Framework;
using System;

namespace MyLibraryTests
{
    [TestFixture]
    public class CalculatorTests
    {
        Calculator calc = null;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            calc = new Calculator();
        }

        [Test]
        public void Add_twoPositiveNumbers_SumCorrect()
        {
            Console.WriteLine("SH: Adding 1 and 2");
            Assert.That(calc.Add(1, 2), Is.EqualTo(3));
            Console.WriteLine("SH: Success!");
        }
    }
}
