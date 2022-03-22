using Modul_16;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_16_Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void TestAdditional()
        {
            Calculator calc = new Calculator();
            Assert.That(calc.Additional(4,9)==13);

        }
        [Test]
        public void TestSubtraction()
        {
            Calculator calc = new Calculator();
            Assert.That(calc.Subtraction(6,3)== 3);

        }
        [Test]
        public void TestMiltiplication()
        {
            Calculator calc = new Calculator();
            Assert.True(calc.Miltiplication(4,2) == 8);

        }
        [Test]
        public void TestDivision()
        {
            Calculator calc = new Calculator();
            Assert.That(calc.Division(10,2)==5);

        }
    }
}
