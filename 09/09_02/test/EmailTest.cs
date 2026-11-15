namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class EmailTest
    {
        [TestMethod]
        public void Constructor_SetsPropertiesCorrectly()
        {
            // Arrange
            var verzender = new Persoon("John", "Doe", "john.doe@example.com");
            var ontvanger = new Persoon("Jane", "Smith", "jane.smith@example.com");
            var email = new Email(verzender, ontvanger, "Test Email", "This is a test email.");

            // Assert
            Assert.AreEqual(verzender, email.Verzender);
            Assert.AreEqual(ontvanger, email.Ontvanger);
            Assert.AreEqual("Test Email", email.Titel);
            Assert.AreEqual("This is a test email.", email.Bericht);
        }

        [TestMethod]
        public void ToString_Method_ReturnsCorrectString()
        {
            // Arrange
            var verzender = new Persoon("John", "Doe", "john.doe@example.com");
            var ontvanger = new Persoon("Jane", "Smith", "jane.smith@example.com");
            var email = new Email(verzender, ontvanger, "Test Email", "This is a test email.");

            // Act
            var result = email.ToString();

            // Assert
            StringAssert.Contains(result, "Verzender: John Doe (john.doe@example.com)");
            StringAssert.Contains(result, "Ontvanger: Jane Smith (jane.smith@example.com)");
            StringAssert.Contains(result, "Titel: Test Email");
            StringAssert.Contains(result, "Bericht: This is a test email");
        }

        [TestMethod]
        public void Equals_Method_ReturnsTrueForEqualObjects()
        {
            // Arrange
            var verzender1 = new Persoon("John", "Doe", "john.doe@example.com");
            var ontvanger1 = new Persoon("Jane", "Smith", "jane.smith@example.com");
            var email1 = new Email(verzender1, ontvanger1, "Test Email", "This is a test email.");

            var verzender2 = new Persoon("John", "Doe", "john.doe@example.com");
            var ontvanger2 = new Persoon("Jane", "Smith", "jane.smith@example.com");
            var email2 = new Email(verzender2, ontvanger2, "Test Email", "This is a test email.");

            // Act
            var result = email1.Equals(email2);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Equals_Method_ReturnsFalseForDifferentObjects()
        {
            // Arrange
            var verzender1 = new Persoon("John", "Doe", "john.doe@example.com");
            var ontvanger1 = new Persoon("Jane", "Smith", "jane.smith@example.com");
            var email1 = new Email(verzender1, ontvanger1, "Test Email", "This is a test email.");

            var verzender2 = new Persoon("John", "Doe", "john.doe@example.com");
            var ontvanger2 = new Persoon("Jane", "Doe", "jane.doe@example.com");
            var email2 = new Email(verzender2, ontvanger2, "Another Email", "Another test email.");

            // Act
            var result = email1.Equals(email2);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GetHashCode_Method_ReturnsConsistentHashForEqualObjects()
        {
            // Arrange
            var verzender1 = new Persoon("John", "Doe", "john.doe@example.com");
            var ontvanger1 = new Persoon("Jane", "Smith", "jane.smith@example.com");
            var email1 = new Email(verzender1, ontvanger1, "Test Email", "This is a test email.");

            var verzender2 = new Persoon("John", "Doe", "john.doe@example.com");
            var ontvanger2 = new Persoon("Jane", "Smith", "jane.smith@example.com");
            var email2 = new Email(verzender2, ontvanger2, "Test Email", "This is a test email.");

            // Act
            var hash1 = email1.GetHashCode();
            var hash2 = email2.GetHashCode();

            // Assert
            Assert.AreEqual(hash1, hash2);
        }

        [TestMethod]
        public void GetHashCode_Method_ReturnsDifferentHashForDifferentObjects()
        {
            // Arrange
            var verzender1 = new Persoon("John", "Doe", "john.doe@example.com");
            var ontvanger1 = new Persoon("Jane", "Smith", "jane.smith@example.com");
            var email1 = new Email(verzender1, ontvanger1, "Test Email", "This is a test email.");

            var verzender2 = new Persoon("John", "Doe", "john.doe@example.com");
            var ontvanger2 = new Persoon("Jane", "Doe", "jane.doe@example.com");
            var email2 = new Email(verzender2, ontvanger2, "Another Email", "Another test email.");

            // Act
            var hash1 = email1.GetHashCode();
            var hash2 = email2.GetHashCode();

            // Assert
            Assert.AreNotEqual(hash1, hash2);
        }
    }
}