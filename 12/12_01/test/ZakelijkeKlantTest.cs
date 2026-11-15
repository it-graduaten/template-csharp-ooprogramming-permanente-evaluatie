namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class ZakelijkeKlantTest
    {
        [TestMethod]
        public void ZakelijkeKlant_Constructor_CreatesInstance()
        {
            // Arrange
            ZakelijkeKlant zakelijkeKlant;

            // Act
            try
            {
                zakelijkeKlant = new ZakelijkeKlant(1, "Business Inc.", "123 Business St", "Business City", "54321", "BE123456789");
            }
            catch (Exception)
            {
                // If an exception is thrown, the test will fail
                Assert.Fail("Exception should not be thrown.");
                return;
            }

            // Assert
            Assert.IsNotNull(zakelijkeKlant);
        }

        [TestMethod]
        public void ZakelijkeKlant_BtwNummer_ValidBtwNummer_DoesNotThrowException()
        {
            // Arrange
            ZakelijkeKlant zakelijkeKlant = new ZakelijkeKlant(1, "Business Inc.", "123 Business St", "Business City", "54321", "BE123456789");

            // Act
            try
            {
                zakelijkeKlant.BtwNummer = "BE987654321";
            }
            catch (Exception)
            {
                // If an exception is thrown, the test will fail
                Assert.Fail("Exception should not be thrown.");
                return;
            }

            // Assert
            Assert.AreEqual("BE987654321", zakelijkeKlant.BtwNummer);
        }

        [TestMethod]
        [ExpectedException(typeof(OngeldigBtwNummerException))]
        public void ZakelijkeKlant_BtwNummer_InvalidBtwNummer_ThrowsException()
        {
            // Arrange
            ZakelijkeKlant zakelijkeKlant = new ZakelijkeKlant(1, "Business Inc.", "123 Business St", "Business City", "54321", "BE123456789");

            // Act
            zakelijkeKlant.BtwNummer = "NL123456789";

            // Assert
            // Expecting OngeldigBtwNummerException
        }

        [TestMethod]
        public void ZakelijkeKlant_ToString_ReturnsExpectedString()
        {
            // Arrange
            ZakelijkeKlant zakelijkeKlant = new ZakelijkeKlant(1, "Business Inc.", "123 Business St", "Business City", "54321", "BE123456789");

            // Act
            string result = zakelijkeKlant.ToString();

            // Assert
            StringAssert.Contains(result, "1");
            StringAssert.Contains(result, "Business Inc.");
            StringAssert.Contains(result, "123 Business St");
            StringAssert.Contains(result, "54321 Business City");
        }
    }
}