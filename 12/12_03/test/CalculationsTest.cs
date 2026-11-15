namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class CalculationsTest
    {
        [TestMethod]
        public void DivideNumbers_ValidValues_ReturnsCorrectResult()
        {
            // Arrange
            double dividend = 10.0;
            double divisor = 2.0;

            // Act
            double result = Calculations.DivideNumbers(dividend, divisor);

            // Assert
            Assert.AreEqual(5.0, result);
        }

        [TestMethod]
        public void DivideNumbers_DivideByZero_ThrowsDivideByZeroException()
        {
            // Arrange
            double dividend = 10.0;
            double divisor = 0.0;

            // Act & Assert
            Assert.ThrowsException<DivideByZeroException>(() => Calculations.DivideNumbers(dividend, divisor));
        }

        [TestMethod]
        public void CalculateSquareRoot_ValidPositiveNumber_ReturnsCorrectResult()
        {
            // Arrange
            double number = 16.0;

            // Act
            double result = Calculations.CalculateSquareRoot(number);

            // Assert
            Assert.AreEqual(4.0, result);
        }

        [TestMethod]
        public void CalculateSquareRoot_NegativeNumber_ThrowsArithmeticException()
        {
            // Arrange
            double number = -16.0;

            // Act & Assert
            Assert.ThrowsException<ArithmeticException>(() => Calculations.CalculateSquareRoot(number));
        }
    }
}