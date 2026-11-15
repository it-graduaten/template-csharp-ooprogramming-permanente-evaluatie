namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class AutoTest
    {
        [TestMethod]
        public void AutoInitialization_Successful()
        {
            // Arrange
            string expectedChassisnummer = "ABC123";
            string expectedMerk = "Toyota";
            var expectedMotor = new Motor(1500, 200);

            // Act
            var auto = new Auto(expectedChassisnummer, expectedMerk, expectedMotor);

            // Assert
            Assert.IsNotNull(auto);
            Assert.AreEqual(expectedChassisnummer, auto.Chassisnummer);
            Assert.AreEqual(expectedMerk, auto.Merk);
            Assert.AreEqual(expectedMotor, auto.Motor);
        }

        [TestMethod]
        public void SetAndGetChassisnummer_Successful()
        {
            // Arrange
            var auto = new Auto("XYZ789", "Honda", new Motor(1200, 180));
            string expectedChassisnummer = "DEF456";

            // Act
            auto.Chassisnummer = expectedChassisnummer;
            var resultChassisnummer = auto.Chassisnummer;

            // Assert
            Assert.AreEqual(expectedChassisnummer, resultChassisnummer);
        }

        [TestMethod]
        public void SetAndGetMerk_Successful()
        {
            // Arrange
            var auto = new Auto("JKL012", "Ford", new Motor(1600, 250));
            string expectedMerk = "Chevrolet";

            // Act
            auto.Merk = expectedMerk;
            var resultMerk = auto.Merk;

            // Assert
            Assert.AreEqual(expectedMerk, resultMerk);
        }

        [TestMethod]
        public void SetAndGetMotor_Successful()
        {
            // Arrange
            var auto = new Auto("MNO345", "Volkswagen", new Motor(1800, 300));
            var expectedMotor = new Motor(2000, 350);

            // Act
            auto.Motor = expectedMotor;
            var resultMotor = auto.Motor;

            // Assert
            Assert.AreEqual(expectedMotor, resultMotor);
        }

        [TestMethod]
        public void ToString_ReturnsCorrectString()
        {
            // Arrange
            var auto = new Auto("PQR678", "BMW", new Motor(2200, 400));

            // Act
            var result = auto.ToString();

            // Assert
            StringAssert.Contains(result, "De BMW met chassisnummer PQR678 heeft de volgende kenmerken");
            StringAssert.Contains(result, "Cilinderinhoud: 2200 - Pk: 400");
        }

        [TestMethod]
        public void Equals_ReturnsTrueForEqualObjects()
        {
            // Arrange
            var auto1 = new Auto("ABC123", "Toyota", new Motor(1500, 200));
            var auto2 = new Auto("ABC123", "Honda", new Motor(1200, 180));

            // Act
            var result = auto1.Equals(auto2);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Equals_ReturnsFalseForDifferentObjects()
        {
            // Arrange
            var auto1 = new Auto("ABC123", "Toyota", new Motor(1500, 200));
            var auto2 = new Auto("XYZ789", "Honda", new Motor(1200, 180));

            // Act
            var result = auto1.Equals(auto2);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GetHashCode_ReturnsSameHashCodeForEqualObjects()
        {
            // Arrange
            var auto1 = new Auto("ABC123", "Toyota", new Motor(1500, 200));
            var auto2 = new Auto("ABC123", "Honda", new Motor(1200, 180));

            // Act
            var hashCode1 = auto1.GetHashCode();
            var hashCode2 = auto2.GetHashCode();

            // Assert
            Assert.AreEqual(hashCode1, hashCode2);
        }
    }
}