namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class ProductBestaatReedsExceptionTest
    {
        [TestMethod]
        public void ProductBestaatReedsException_Constructor_ValidMessage()
        {
            // Act
            ProductBestaatReedsException exception = new ProductBestaatReedsException();

            // Assert
            Assert.IsNotNull(exception);
            Assert.AreEqual("Product bestaat reeds!", exception.Message);
        }
    }
}