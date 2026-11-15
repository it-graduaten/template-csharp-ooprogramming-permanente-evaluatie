namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class PersoonTest
    {
        [TestMethod]
        public void Persoon_Constructor_InitializesPropertiesCorrectly()
        {
            // Arrange
            string expectedVoornaam = "John";
            string expectedAchternaam = "Doe";

            // Act
            Persoon persoon = new Persoon(expectedVoornaam, expectedAchternaam);

            // Assert
            Assert.AreEqual(expectedVoornaam, persoon.Voornaam);
            Assert.AreEqual(expectedAchternaam, persoon.Achternaam);
        }

        [TestMethod]
        public void Persoon_ToString_ReturnsCorrectFormat()
        {
            // Arrange
            string voornaam = "Jane";
            string achternaam = "Smith";
            Persoon persoon = new Persoon(voornaam, achternaam);

            // Act
            string result = persoon.ToString();

            // Assert
            StringAssert.Contains(result, voornaam, "De voornaam is niet aanwezig in de ToString() output.");
            StringAssert.Contains(result, achternaam, "De achternaam is niet aanwezig in de ToString() output.");
        }
    }
}