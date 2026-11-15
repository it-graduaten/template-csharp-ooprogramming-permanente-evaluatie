namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class FileOperationsTest
    {
        private const string TestFilePath = "contacten.txt";

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            // Create a test file with sample data
            using (StreamWriter writer = new StreamWriter(TestFilePath))
            {
                writer.WriteLine("John;Doe;john.doe@example.com");
                writer.WriteLine("Jane;Smith;jane.smith@example.com");
            }
        }

        [TestMethod]
        public void LeesContacten_ReturnsCorrectList()
        {
            // Act
            List<Persoon> contacten = FileOperations.LeesContacten();

            // Assert
            Assert.IsNotNull(contacten);
            Assert.AreEqual(2, contacten.Count);
        }

        [TestMethod]
        public void LeesContacten_ReadsDataCorrectly()
        {
            // Act
            List<Persoon> contacten = FileOperations.LeesContacten();

            // Assert
            Assert.AreEqual("John", contacten[0].Voornaam);
            Assert.AreEqual("Doe", contacten[0].Familienaam);
            Assert.AreEqual("john.doe@example.com", contacten[0].Email);

            Assert.AreEqual("Jane", contacten[1].Voornaam);
            Assert.AreEqual("Smith", contacten[1].Familienaam);
            Assert.AreEqual("jane.smith@example.com", contacten[1].Email);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            // Delete the test file
            File.Delete(TestFilePath);
        }
    }
}