using VsLiveRedmond.Api;

namespace RedmondUnitTestSample
{
    [TestClass]
    public class CalculatorFixture
    {
        [TestMethod]
        public void Add()
        {
            // Arrange
            var value1 = 2;
            var value2 = 3;

            var sut = new Calculator();

            // The expected returned value.
            var expected = 4;

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
            Assert.Inconclusive();
        }

        [TestMethod]
        public void Multiply()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void Divide()
        {
            Assert.Inconclusive();
        }
    }
}