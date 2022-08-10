using VsLiveRedmond.Api;

namespace RedmondUnitTestSample
{
    [TestClass]
    public class CalculatorFixture
    {
        [TestInitialize]
        public void OnTestInitialize()
        {
            _calculator = null;
        }

        private Calculator? _calculator;

        // This is a singleton pattern class.
        public Calculator SystemUnderTest => _calculator ??= new Calculator();

        [TestMethod]
        public void Add()
        {
            // Arrange
            var value1 = 2;
            var value2 = 3;

            var sut = new Calculator();

            // The expected returned value.
            var expected = 5;

            // Act
            // The actual returned value.
            var actual = sut.Add(value1, value2);

            // Assert
            // An assertion that the values are equal.
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void Subtract()
        {
            // Arrange
            var value1 = 2;
            var value2 = 2;

            var sut = new Calculator();

            // The expected returned value.
            var expected = 0;

            // Act
            // The actual returned value.
            var actual = sut.Subtract(value1, value2);

            // Assert
            // An assertion that the values are equal.
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void Multiply()
        {
            // Arrange
            var value1 = 6;
            var value2 = 3;

            var sut = new Calculator();

            // The expected returned value.
            var expected = 18;

            // Act
            // The actual returned value.
            var actual = sut.Multiply(value1, value2);

            // Assert
            // An assertion that the values are equal.
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        public void Divide()
        {
            // Arrange
            var value1 = 10;
            var value2 = 5;

            var sut = new Calculator();

            // The expected returned value.
            var expected = 2;

            // Act
            // The actual returned value.
            var actual = sut.Divide(value1, value2);

            // Assert
            // An assertion that the values are equal.
            Assert.AreEqual<int>(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void DivideByZero()
        {
            // Arrange
            var value1 = 10;
            var value2 = 0;

            var sut = new Calculator();

            // The expected returned value.
            var expected = 2;

            // Act
            // The actual returned value.
            var actual = sut.Divide(value1, value2);

            // Assert
            // An assertion that the values are equal.
            Assert.AreEqual<int>(expected, actual);
        }
    }
}