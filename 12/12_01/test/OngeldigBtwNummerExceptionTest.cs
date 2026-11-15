namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class OngeldigBtwNummerExceptionTest
    {
        [TestMethod]
        public void OngeldigBtwNummerException_Constructor_ValidMessage()
        {
            // Act
            OngeldigBtwNummerException exception = new OngeldigBtwNummerException();

            // Assert
            Assert.IsNotNull(exception);
            Assert.AreEqual("Het BTW-nummer moet beginnen met BE.", exception.Message);
        }
    }
}