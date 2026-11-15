namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class KlantTest
    {
        [TestMethod]
        public void Klant_Equals_ReturnsTrueForEqualKlanten()
        {
            // Arrange
            Klant klant1 = new Klant(1, "John Doe", "123 Main St", "City1", "12345");
            Klant klant2 = new Klant(1, "John Doe", "123 Main St", "City1", "12345");

            // Act
            bool result = klant1.Equals(klant2);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Klant_Equals_ReturnsFalseForDifferentKlanten()
        {
            // Arrange
            Klant klant1 = new Klant(1, "John Doe", "123 Main St", "City1", "12345");
            Klant klant2 = new Klant(2, "Jane Smith", "456 Oak St", "City2", "67890");

            // Act
            bool result = klant1.Equals(klant2);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Klant_ToString_ReturnsExpectedString()
        {
            // Arrange
            Klant klant = new Klant(1, "John Doe", "123 Main St", "City1", "12345");
            string expectedString = "1\nJohn Doe\n123 Main St\n12345 City1";

            // Act
            string result = klant.ToString();

            // Assert
            Assert.AreEqual(expectedString, result);
        }

        [TestMethod]
        public void Klant_GetHashCode_ReturnsSameHashCodeForEqualKlanten()
        {
            // Arrange
            Klant klant1 = new Klant(1, "John Doe", "123 Main St", "City1", "12345");
            Klant klant2 = new Klant(1, "John Doe", "123 Main St", "City1", "12345");

            // Act
            int hashCode1 = klant1.GetHashCode();
            int hashCode2 = klant2.GetHashCode();

            // Assert
            Assert.AreEqual(hashCode1, hashCode2);
        }

        [TestMethod]
        public void Klant_GetHashCode_ReturnsDifferentHashCodeForDifferentKlanten()
        {
            // Arrange
            Klant klant1 = new Klant(1, "John Doe", "123 Main St", "City1", "12345");
            Klant klant2 = new Klant(2, "Jane Smith", "456 Oak St", "City2", "67890");

            // Act
            int hashCode1 = klant1.GetHashCode();
            int hashCode2 = klant2.GetHashCode();

            // Assert
            Assert.AreNotEqual(hashCode1, hashCode2);
        }
    }
}