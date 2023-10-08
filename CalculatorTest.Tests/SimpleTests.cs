using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorTest.Data;

// Given that the implementation of ISimpleCalculator.cs is simple and does not do any time-intensive tasks such as connecting to databases;
// I have decided to use that implemtation in the Unit Tests instead of implementing a Mock

namespace CalculatorTest.Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Add_TwoPositives_ReturnsSum()
        {
            // Arrange
            var simpleCalculator = new SimpleCalculator();

            // Act
            var actual = simpleCalculator.Add(2, 5);

            // Assert
            Assert.AreEqual(7, actual);
        }

        [TestMethod]
        public void Add_PositiveAndNegative_ReturnsSum()
        {
            // Arrange
            var simpleCalculator = new SimpleCalculator();

            // Act
            var actual = simpleCalculator.Add(3, -6);

            // Assert
            Assert.AreEqual(-3, actual);
        }

        [TestMethod]
        public void Add_TwoNegatives_ReturnsSum()
        {
            // Arrange
            var simpleCalculator = new SimpleCalculator();

            // Act
            var actual = simpleCalculator.Add(-4, -8);

            // Assert
            Assert.AreEqual(-12, actual);
        }

        [TestMethod]
        public void Subtract_TwoPositives_ReturnsDifference()
        {
            // Arrange
            var simpleCalculator = new SimpleCalculator();

            // Act
            var actual = simpleCalculator.Subtract(2, 5);

            // Assert
            Assert.AreEqual(-3, actual);
        }

        [TestMethod]
        public void Subtract_PositiveAndNegative_ReturnsDifference()
        {
            // Arrange
            var simpleCalculator = new SimpleCalculator();

            // Act
            var actual = simpleCalculator.Subtract(3, -6);

            // Assert
            Assert.AreEqual(9, actual);
        }

        [TestMethod]
        public void Subtract_TwoNegatives_ReturnsDifference()
        {
            // Arrange
            var simpleCalculator = new SimpleCalculator();

            // Act
            var actual = simpleCalculator.Subtract(-4, -8);

            // Assert
            Assert.AreEqual(4, actual);
        }
    }
}
