namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class PersoneelslidTest
    {
        [TestMethod]
        public void Constructor_SetsPropertiesCorrectly()
        {
            // Arrange
            var personeelslid = new Personeelslid("John", "Doe", true);

            // Assert
            Assert.AreEqual("John", personeelslid.Voornaam);
            Assert.AreEqual("Doe", personeelslid.Familienaam);
            Assert.IsTrue(personeelslid.IsStagiair);
        }

        [TestMethod]
        public void ToString_Method_ReturnsCorrectStringForStagiair()
        {
            // Arrange
            var personeelslid = new Personeelslid("John", "Doe", true);

            // Act
            var result = personeelslid.ToString();

            // Assert
            Assert.AreEqual("John Doe (Stagair)", result);
        }

        [TestMethod]
        public void ToString_Method_ReturnsCorrectStringForNonStagair()
        {
            // Arrange
            var personeelslid = new Personeelslid("Jane", "Smith", false);

            // Act
            var result = personeelslid.ToString();

            // Assert
            Assert.AreEqual("Jane Smith (Vaste medewerker)", result);
        }

        [TestMethod]
        public void Equals_Method_ReturnsTrueForEqualObjects()
        {
            // Arrange
            var personeelslid1 = new Personeelslid("John", "Doe", true);
            var personeelslid2 = new Personeelslid("John", "Doe", true);

            // Act
            var result = personeelslid1.Equals(personeelslid2);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Equals_Method_ReturnsFalseForDifferentObjects()
        {
            // Arrange
            var personeelslid1 = new Personeelslid("John", "Doe", true);
            var personeelslid2 = new Personeelslid("Jane", "Smith", false);

            // Act
            var result = personeelslid1.Equals(personeelslid2);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GetHashCode_Method_ReturnsConsistentHashForEqualObjects()
        {
            // Arrange
            var personeelslid1 = new Personeelslid("John", "Doe", true);
            var personeelslid2 = new Personeelslid("John", "Doe", true);

            // Act
            var hash1 = personeelslid1.GetHashCode();
            var hash2 = personeelslid2.GetHashCode();

            // Assert
            Assert.AreEqual(hash1, hash2);
        }

        [TestMethod]
        public void GetHashCode_Method_ReturnsDifferentHashForDifferentObjects()
        {
            // Arrange
            var personeelslid1 = new Personeelslid("John", "Doe", true);
            var personeelslid2 = new Personeelslid("Jane", "Smith", false);

            // Act
            var hash1 = personeelslid1.GetHashCode();
            var hash2 = personeelslid2.GetHashCode();

            // Assert
            Assert.AreNotEqual(hash1, hash2);
        }
    }
}