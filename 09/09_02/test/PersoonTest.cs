namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class PersoonTest
    {
        [TestMethod]
        public void Constructor_SetsPropertiesCorrectly()
        {
            // Arrange
            var persoon = new Persoon("John", "Doe", "john.doe@example.com");

            // Assert
            Assert.AreEqual("John", persoon.Voornaam);
            Assert.AreEqual("Doe", persoon.Familienaam);
            Assert.AreEqual("john.doe@example.com", persoon.Email);
        }

        [TestMethod]
        public void ToString_Method_ReturnsCorrectString()
        {
            // Arrange
            var persoon = new Persoon("John", "Doe", "john.doe@example.com");

            // Act
            var result = persoon.ToString();

            // Assert
            Assert.AreEqual("John Doe (john.doe@example.com)", result);
        }

        [TestMethod]
        public void Equals_Method_ReturnsTrueForEqualObjects()
        {
            // Arrange
            var persoon1 = new Persoon("John", "Doe", "john.doe@example.com");
            var persoon2 = new Persoon("Jane", "Doe", "john.doe@example.com");

            // Act
            var result = persoon1.Equals(persoon2);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Equals_Method_ReturnsFalseForDifferentObjects()
        {
            // Arrange
            var persoon1 = new Persoon("John", "Doe", "john.doe@example.com");
            var persoon2 = new Persoon("John", "Smith", "john.smith@example.com");

            // Act
            var result = persoon1.Equals(persoon2);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GetHashCode_Method_ReturnsConsistentHashForEqualObjects()
        {
            // Arrange
            var persoon1 = new Persoon("John", "Doe", "john.doe@example.com");
            var persoon2 = new Persoon("Jane", "Doe", "john.doe@example.com");

            // Act
            var hash1 = persoon1.GetHashCode();
            var hash2 = persoon2.GetHashCode();

            // Assert
            Assert.AreEqual(hash1, hash2);
        }

        [TestMethod]
        public void GetHashCode_Method_ReturnsDifferentHashForDifferentObjects()
        {
            // Arrange
            var persoon1 = new Persoon("John", "Doe", "john.doe@example.com");
            var persoon2 = new Persoon("John", "Smith", "john.smith@example.com");

            // Act
            var hash1 = persoon1.GetHashCode();
            var hash2 = persoon2.GetHashCode();

            // Assert
            Assert.AreNotEqual(hash1, hash2);
        }
    }
}