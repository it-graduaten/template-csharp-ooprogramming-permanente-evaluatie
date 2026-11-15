namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class FileOperationsTest
    {
        private const string TestFilePath = "test_students.txt";

        [TestMethod]
        public void LeesStudenten_WhenFileExists_ReturnsCorrectList()
        {
            // Arrange
            var expectedStudenten = new List<Student>
            {
                new Student(1, "Doe", "John", 85, 90),
                new Student(2, "Smith", "Alice", 78, 96),
                new Student(3, "Johnson", "Bob", 92, 78)
            };
            CreateTestFile(expectedStudenten);

            // Act
            var resultStudenten = FileOperations.LeesStudenten(TestFilePath);

            // Assert
            CollectionAssert.AreEqual(expectedStudenten, resultStudenten);
        }

        [TestMethod]
        public void LeesStudenten_WithInvalidFileFormat_ThrowsException()
        {
            // Arrange
            var invalidContent = "InvalidFormat";
            File.WriteAllText(TestFilePath, invalidContent);

            // Act & Assert
            Assert.ThrowsException<FormatException>(() => FileOperations.LeesStudenten(TestFilePath));
        }

        [TestMethod]
        public void LeesStudenten_WithEmptyFile_ReturnsEmptyList()
        {
            // Arrange
            File.WriteAllText(TestFilePath, string.Empty);

            // Act
            var resultStudenten = FileOperations.LeesStudenten(TestFilePath);

            // Assert
            Assert.IsNotNull(resultStudenten);
            Assert.AreEqual(0, resultStudenten.Count);
        }

        private void CreateTestFile(List<Student> students)
        {
            using (StreamWriter sw = new StreamWriter(TestFilePath))
            {
                foreach (var student in students)
                {
                    sw.WriteLine($"{student.Id};{student.Naam};{student.Voornaam};{student.PuntWiskunde};{student.PuntNederlands}");
                }
            }
        }
    }
}