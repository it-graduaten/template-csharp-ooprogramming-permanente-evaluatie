namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class FileOperationsTest
    {
        [TestMethod]
        public void FileOperations_LeesPersonen_ReturnsCorrectList()
        {

            // Act
            List<Persoon> personen = FileOperations.LeesPersonen();

            // Assert
            Assert.AreEqual(70, personen.Count);
            Assert.IsInstanceOfType(personen[0], typeof(Voetbalspeler));
            Assert.IsInstanceOfType(personen[51], typeof(Trainer));
        }

        [TestMethod]
        public void FileOperations_LeesTrainers_ReturnsCorrectList()
        {

            // Act
            List<Trainer> trainers = FileOperations.LeesTrainers();

            // Assert
            Assert.AreEqual(20, trainers.Count);
            Assert.AreEqual("Pep", trainers[0].Voornaam);
            Assert.AreEqual("Guardiola", trainers[0].Achternaam);
            Assert.AreEqual(12000000, trainers[0].Salaris);
        }

        [TestMethod]
        public void FileOperations_LeesSpelers_ReturnsCorrectList()
        {

            // Act
            List<Voetbalspeler> spelers = FileOperations.LeesSpelers();

            // Assert
            Assert.AreEqual(50, spelers.Count);
            Assert.AreEqual("Lionel", spelers[0].Voornaam);
            Assert.AreEqual("Messi", spelers[0].Achternaam);
            Assert.AreEqual("Aanvaller", spelers[0].Positie);
        }
    }
}