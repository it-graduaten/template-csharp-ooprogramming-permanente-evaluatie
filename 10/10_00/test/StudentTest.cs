namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class StudentTest
    {
        [TestMethod]
        public void StudentInitialization_Successful()
        {
            // Arrange
            int expectedId = 1;
            string expectedNaam = "Doe";
            string expectedVoornaam = "John";
            int expectedPuntWiskunde = 85;
            int expectedPuntNederlands = 90;

            // Act
            var student = new Student(expectedId, expectedNaam, expectedVoornaam, expectedPuntWiskunde, expectedPuntNederlands);

            // Assert
            Assert.IsNotNull(student);
            Assert.AreEqual(expectedId, student.Id);
            Assert.AreEqual(expectedNaam, student.Naam);
            Assert.AreEqual(expectedVoornaam, student.Voornaam);
            Assert.AreEqual(expectedPuntWiskunde, student.PuntWiskunde);
            Assert.AreEqual(expectedPuntNederlands, student.PuntNederlands);
        }

        [TestMethod]
        public void SetAndGetId_Successful()
        {
            // Arrange
            var student = new Student(2, "Smith", "Alice", 75, 88);
            int expectedId = 3;

            // Act
            student.Id = expectedId;
            var resultId = student.Id;

            // Assert
            Assert.AreEqual(expectedId, resultId);
        }

        [TestMethod]
        public void SetAndGetName_Successful()
        {
            // Arrange
            var student = new Student(4, "Johnson", "Bob", 92, 78);
            string expectedNaam = "Brown";

            // Act
            student.Naam = expectedNaam;
            var resultNaam = student.Naam;

            // Assert
            Assert.AreEqual(expectedNaam, resultNaam);
        }

        [TestMethod]
        public void SetAndGetVoornaam_Successful()
        {
            // Arrange
            var student = new Student(5, "Williams", "Eva", 80, 95);
            string expectedVoornaam = "Michael";

            // Act
            student.Voornaam = expectedVoornaam;
            var resultVoornaam = student.Voornaam;

            // Assert
            Assert.AreEqual(expectedVoornaam, resultVoornaam);
        }

        [TestMethod]
        public void SetAndGetPuntWiskunde_Successful()
        {
            // Arrange
            var student = new Student(6, "Davis", "Emma", 88, 82);
            int expectedPuntWiskunde = 91;

            // Act
            student.PuntWiskunde = expectedPuntWiskunde;
            var resultPuntWiskunde = student.PuntWiskunde;

            // Assert
            Assert.AreEqual(expectedPuntWiskunde, resultPuntWiskunde);
        }

        [TestMethod]
        public void SetAndGetPuntNederlands_Successful()
        {
            // Arrange
            var student = new Student(7, "Miller", "David", 78, 96);
            int expectedPuntNederlands = 89;

            // Act
            student.PuntNederlands = expectedPuntNederlands;
            var resultPuntNederlands = student.PuntNederlands;

            // Assert
            Assert.AreEqual(expectedPuntNederlands, resultPuntNederlands);
        }

        [TestMethod]
        public void ToString_ReturnsCorrectString()
        {
            // Arrange
            var student = new Student(8, "Garcia", "Sophia", 85, 90);

            // Act
            var result = student.ToString();

            // Assert
            var expected = "8 - Garcia Sophia - Punt wiskunde: 85 - Punt nederlands: 90";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Equals_ReturnsTrueForEqualObjects()
        {
            // Arrange
            var student1 = new Student(9, "Anderson", "James", 89, 84);
            var student2 = new Student(9, "Anderson", "Jennifer", 92, 78);

            // Act
            var result = student1.Equals(student2);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Equals_ReturnsFalseForDifferentObjects()
        {
            // Arrange
            var student1 = new Student(10, "Thomas", "Liam", 93, 91);
            var student2 = new Student(11, "Thomas", "Olivia", 88, 85);

            // Act
            var result = student1.Equals(student2);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GetHashCode_ReturnsSameHashCodeForEqualObjects()
        {
            // Arrange
            var student1 = new Student(12, "Jackson", "Lucas", 86, 87);
            var student2 = new Student(12, "Jackson", "Chloe", 90, 92);

            // Act
            var hashCode1 = student1.GetHashCode();
            var hashCode2 = student2.GetHashCode();

            // Assert
            Assert.AreEqual(hashCode1, hashCode2);
        }
    }
}