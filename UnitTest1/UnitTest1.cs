namespace CalculatorTester
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            //
        }

        [Test]
        [TestCase(2, 3)]
        [TestCase(1, 5)]
        [TestCase(7, 4)]
        [TestCase(2.5f, 5.5f)]
        [TestCase(3.2f, 4.8f)]
        [TestCase(6.6f, 3.4f)]
        [TestCase(7.5f, 4)]
        [TestCase(10, 7.5f)]
        public void TestAddFunction(float num1, float num2)
        {
            var result = Calculator.Add(num1, num2);
            Assert.AreEqual(result, num1 + num2);
        }

        [Test]
        [TestCase(2, 3)]
        [TestCase(5, 1)]
        [TestCase(7, 4)]
        [TestCase(9.5f, 5.5f)]
        [TestCase(3.2f, 4.8f)]
        [TestCase(6.6f, 3.4f)]
        [TestCase(7.5f, 4)]
        [TestCase(10, 7.5f)]
        public void TestSubtractFunction(float num1, float num2)
        {
            var result = Calculator.Subtract(num1, num2);
            Assert.AreEqual(result, num1 - num2);
        }

        [Test]
        [TestCase(2, 3)]
        [TestCase(5, 1)]
        [TestCase(7, 4)]
        [TestCase(9.5f, 5.5f)]
        [TestCase(3.2f, 4.8f)]
        [TestCase(6.6f, 3.4f)]
        [TestCase(7.5f, 4)]
        [TestCase(10, 7.5f)]
        public void TestMultiplyFunction(float num1, float num2)
        {
            var result = Calculator.Multiply(num1, num2);
            Assert.AreEqual(result, num1 * num2);
        }

        [Test]
        [TestCase(2, 3)]
        [TestCase(5, 0)]
        [TestCase(7, 4)]
        [TestCase(9.5f, 5.5f)]
        [TestCase(3.2f, 4.8f)]
        [TestCase(6.6f, 3.4f)]
        [TestCase(7.5f, 4)]
        [TestCase(10, 7.5f)]
        public void TestDivideFunction(float num1, float num2)
        {
            var result = Calculator.Divide(num1, num2);
            Assert.AreEqual(result, num1 / num2);
        }
    }
}