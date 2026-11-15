namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class NumeriekeWaardeOnderNulExceptionTest
    {
        [TestMethod]
        public void NumeriekeWaardeOnderNulException_Constructor_ValidMessage()
        {
            // Arrange
            string attribuut = "TestAttribuut";

            // Act
            NumeriekeWaardeOnderNulException exception = new NumeriekeWaardeOnderNulException(attribuut);

            // Assert
            Assert.IsNotNull(exception);
            Assert.AreEqual($"{attribuut} mag geen waarde onder nul bevatten!", exception.Message);
        }
    }
}