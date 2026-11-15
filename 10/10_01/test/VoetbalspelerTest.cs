namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class VoetbalspelerTest
    {
        [TestMethod]
        public void Voetbalspeler_Constructor_InitializesPropertiesCorrectly()
        {
            // Arrange
            string expectedVoornaam = "Lionel";
            string expectedAchternaam = "Messi";
            string expectedPositie = "Aanvaller";

            // Act
            Voetbalspeler voetbalspeler = new Voetbalspeler(expectedVoornaam, expectedAchternaam, expectedPositie);

            // Assert
            Assert.AreEqual(expectedVoornaam, voetbalspeler.Voornaam);
            Assert.AreEqual(expectedAchternaam, voetbalspeler.Achternaam);
            Assert.AreEqual(expectedPositie, voetbalspeler.Positie);
        }

        [TestMethod]
        public void Voetbalspeler_ToString_ReturnsCorrectFormat()
        {
            // Arrange
            string voornaam = "Cristiano";
            string achternaam = "Ronaldo";
            string positie = "Aanvaller";
            Voetbalspeler voetbalspeler = new Voetbalspeler(voornaam, achternaam, positie);

            // Act
            string result = voetbalspeler.ToString();

            // Assert
            string expectedString = $"{voornaam} {achternaam} speelt op positie {positie}";
            Assert.AreEqual(expectedString, result);
        }

        [TestMethod]
        public void Voetbalspeler_Equals_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            Voetbalspeler speler1 = new Voetbalspeler("Harry", "Kane", "Spits");
            Voetbalspeler speler2 = new Voetbalspeler("Harry", "Kane", "Spits");

            // Act & Assert
            Assert.IsTrue(speler1.Equals(speler2));
            Assert.IsTrue(speler1.Equals((object)speler2));
        }

        [TestMethod]
        public void Voetbalspeler_Equals_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            Voetbalspeler speler1 = new Voetbalspeler("Mohamed", "Salah", "Aanvaller");
            Voetbalspeler speler2 = new Voetbalspeler("Robert", "Lewandowski", "Spits");

            // Act & Assert
            Assert.IsFalse(speler1.Equals(speler2));
            Assert.IsFalse(speler1.Equals((object)speler2));
        }

        [TestMethod]
        public void Voetbalspeler_GetHashCode_ReturnsSameHashCodeForEqualObjects()
        {
            // Arrange
            Voetbalspeler speler1 = new Voetbalspeler("Neymar", "Jr.", "Aanvaller");
            Voetbalspeler speler2 = new Voetbalspeler("Neymar", "Jr.", "Aanvaller");

            // Act & Assert
            Assert.AreEqual(speler1.GetHashCode(), speler2.GetHashCode());
        }

        [TestMethod]
        public void Voetbalspeler_GetHashCode_ReturnsDifferentHashCodeForDifferentObjects()
        {
            // Arrange
            Voetbalspeler speler1 = new Voetbalspeler("Luka", "Modric", "Middenvelder");
            Voetbalspeler speler2 = new Voetbalspeler("Kevin", "De Bruyne", "Middenvelder");

            // Act & Assert
            Assert.AreNotEqual(speler1.GetHashCode(), speler2.GetHashCode());
        }
    }
}