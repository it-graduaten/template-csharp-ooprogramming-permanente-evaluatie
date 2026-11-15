namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class TrainerTest
    {
        [TestMethod]
        public void Trainer_Constructor_InitializesPropertiesCorrectly()
        {
            // Arrange
            string expectedVoornaam = "John";
            string expectedAchternaam = "Doe";
            double expectedSalaris = 50000.0;

            // Act
            Trainer trainer = new Trainer(expectedVoornaam, expectedAchternaam, expectedSalaris);

            // Assert
            Assert.AreEqual(expectedVoornaam, trainer.Voornaam);
            Assert.AreEqual(expectedAchternaam, trainer.Achternaam);
            Assert.AreEqual(expectedSalaris, trainer.Salaris);
        }

        [TestMethod]
        public void Trainer_ToString_ReturnsCorrectFormat()
        {
            // Arrange
            string voornaam = "Jane";
            string achternaam = "Smith";
            double salaris = 60000.0;
            Trainer trainer = new Trainer(voornaam, achternaam, salaris);

            // Act
            string result = trainer.ToString();

            // Assert
            string expectedString = $"{voornaam} {achternaam} verdient {salaris} euro";
            Assert.AreEqual(expectedString, result);
        }
    }
}