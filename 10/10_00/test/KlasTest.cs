namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class KlasTest
    {
        [TestMethod]
        public void KlasInitialization_Successful()
        {
            // Arrange
            int expectedId = 1;
            string expectedNaam = "1A";
            var studenten = new List<Student> { new Student(1, "Doe", "John", 85, 90) };

            // Act
            var klas = new Klas(expectedId, expectedNaam, studenten);

            // Assert
            Assert.IsNotNull(klas);
            Assert.AreEqual(expectedId, klas.Id);
            Assert.AreEqual(expectedNaam, klas.Naam);
            CollectionAssert.AreEqual(studenten, klas.Studenten);
        }

        [TestMethod]
        public void SetAndGetId_Successful()
        {
            // Arrange
            var klas = new Klas(2, "2B", new List<Student>());

            int expectedId = 3;

            // Act
            klas.Id = expectedId;
            var resultId = klas.Id;

            // Assert
            Assert.AreEqual(expectedId, resultId);
        }

        [TestMethod]
        public void SetAndGetNaam_Successful()
        {
            // Arrange
            var klas = new Klas(4, "4C", new List<Student>());

            string expectedNaam = "4D";

            // Act
            klas.Naam = expectedNaam;
            var resultNaam = klas.Naam;

            // Assert
            Assert.AreEqual(expectedNaam, resultNaam);
        }

        [TestMethod]
        public void SetAndGetStudenten_Successful()
        {
            // Arrange
            var klas = new Klas(5, "5E", new List<Student>());

            var expectedStudenten = new List<Student>
            {
                new Student(5, "Smith", "Alice", 75, 88),
                new Student(6, "Johnson", "Bob", 92, 78)
            };

            // Act
            klas.Studenten = expectedStudenten;
            var resultStudenten = klas.Studenten;

            // Assert
            CollectionAssert.AreEqual(expectedStudenten, resultStudenten);
        }

        [TestMethod]
        public void BerekenGemiddeldeWiskunde_ReturnsCorrectAverage()
        {
            // Arrange
            var klas = new Klas(7, "7F", new List<Student>
            {
                new Student(7, "Miller", "David", 78, 96),
                new Student(8, "Garcia", "Sophia", 85, 90),
                new Student(9, "Anderson", "James", 89, 84)
            });

            double expectedAverage = (78 + 85 + 89) / 3.0;

            // Act
            var resultAverage = klas.BerekenGemiddeldeWiskunde();

            // Assert
            Assert.AreEqual(expectedAverage, resultAverage, 0.001);
        }

        [TestMethod]
        public void BerekenGemiddeldeNederlands_ReturnsCorrectAverage()
        {
            // Arrange
            var klas = new Klas(10, "10G", new List<Student>
            {
                new Student(10, "Thomas", "Liam", 93, 91),
                new Student(11, "Thomas", "Olivia", 88, 85),
                new Student(12, "Jackson", "Lucas", 86, 87)
            });

            double expectedAverage = (91 + 85 + 87) / 3.0;

            // Act
            var resultAverage = klas.BerekenGemiddeldeNederlands();

            // Assert
            Assert.AreEqual(expectedAverage, resultAverage, 0.001);
        }

        [TestMethod]
        public void ToString_ReturnsCorrectString()
        {
            // Arrange
            var klas = new Klas(13, "13H", new List<Student>
            {
                new Student(13, "Harris", "Ava", 90, 94),
                new Student(14, "Taylor", "Noah", 82, 89),
                new Student(15, "White", "Olivia", 88, 91)
            });

            // Act
            var result = klas.ToString();

            // Assert
            StringAssert.Contains(result, "Klas 13 - 13H");
            StringAssert.Contains(result, "13 - Harris Ava - Punt wiskunde: 90 - Punt nederlands: 94");
            StringAssert.Contains(result, "14 - Taylor Noah - Punt wiskunde: 82 - Punt nederlands: 89");
            StringAssert.Contains(result, "15 - White Olivia - Punt wiskunde: 88 - Punt nederlands: 91");
        }
    }
}