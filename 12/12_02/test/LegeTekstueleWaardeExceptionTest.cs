namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class LegeTekstueleWaardeExceptionTest
    {
        [TestMethod]
        public void LegeTekstueleWaardeException_Constructor_ValidMessage()
        {
            // Arrange
            string attribuut = "TestAttribuut";

            // Act
            LegeTekstueleWaardeException exception = new LegeTekstueleWaardeException(attribuut);

            // Assert
            Assert.IsNotNull(exception);
            Assert.AreEqual($"{attribuut} mag geen lege waarde bevatten!", exception.Message);
        }
    }
}