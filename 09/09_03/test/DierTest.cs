namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class DierTest
    {
        [TestMethod]
        public void Constructor_SetsPropertiesCorrectly()
        {
            // Arrange
            var dier = new Dier("Lion", "Mammal", true);

            // Assert
            Assert.AreEqual("Lion", dier.Naam);
            Assert.AreEqual("Mammal", dier.Diersoort);
            Assert.IsTrue(dier.IsGevaarlijk);
        }

        [TestMethod]
        public void ToString_Method_ReturnsCorrectString()
        {
            // Arrange
            var dier = new Dier("Lion", "Mammal", true);

            // Act
            var result = dier.ToString();

            // Assert
            Assert.AreEqual("Lion (Mammal)", result);
        }

        [TestMethod]
        public void Equals_Method_ReturnsTrueForEqualObjects()
        {
            // Arrange
            var dier1 = new Dier("Lion", "Mammal", true);
            var dier2 = new Dier("Lion", "Mammal", true);

            // Act
            var result = dier1.Equals(dier2);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Equals_Method_ReturnsFalseForDifferentObjects()
        {
            // Arrange
            var dier1 = new Dier("Lion", "Mammal", true);
            var dier2 = new Dier("Tiger", "Mammal", true);

            // Act
            var result = dier1.Equals(dier2);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GetHashCode_Method_ReturnsConsistentHashForEqualObjects()
        {
            // Arrange
            var dier1 = new Dier("Lion", "Mammal", true);
            var dier2 = new Dier("Lion", "Mammal", true);

            // Act
            var hash1 = dier1.GetHashCode();
            var hash2 = dier2.GetHashCode();

            // Assert
            Assert.AreEqual(hash1, hash2);
        }

        [TestMethod]
        public void GetHashCode_Method_ReturnsDifferentHashForDifferentObjects()
        {
            // Arrange
            var dier1 = new Dier("Lion", "Mammal", true);
            var dier2 = new Dier("Tiger", "Mammal", true);

            // Act
            var hash1 = dier1.GetHashCode();
            var hash2 = dier2.GetHashCode();

            // Assert
            Assert.AreNotEqual(hash1, hash2);
        }

        [TestMethod]
        public void Eten_Method_UpdatesLastFedTime()
        {
            // Arrange
            var dier = new Dier("Lion", "Mammal", true);
            var feedingTime = DateTime.Now;

            // Act
            dier.Eten(feedingTime);

            // Assert
            Assert.AreEqual(feedingTime, dier.LaatstGevoerd);
        }

    }
}