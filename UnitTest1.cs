using NUnit.Framework;

namespace LR20
{
    public class Tests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void TestAddition()
        {
            int result = calculator.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void TestSubtraction()
        {
            int result = calculator.Subtract(5, 3);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void TestMultiplication()
        {
            int result = calculator.Multiply(2, 3);
            Assert.AreEqual(6, result);
        }

        [Test]
        public void TestDivision()
        {
            int result = calculator.Divide(6, 3);
            Assert.AreEqual(2, result);
        }
    }

    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }
    }
}