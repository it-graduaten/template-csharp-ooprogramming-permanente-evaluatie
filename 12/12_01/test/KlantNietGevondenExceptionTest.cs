namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class KlantNietGevondenExceptionTest
    {
        [TestMethod]
        public void KlantNietGevondenException_Constructor_ValidMessage()
        {
            // Arrange
            int klantnummer = 123;

            // Act
            KlantNietGevondenException exception = new KlantNietGevondenException(klantnummer);

            // Assert
            Assert.IsNotNull(exception);
            Assert.AreEqual($"Klant met nummer {klantnummer} bestaat niet.", exception.Message);
        }
    }
}