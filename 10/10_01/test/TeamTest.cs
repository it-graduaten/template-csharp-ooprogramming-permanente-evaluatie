namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class TeamTest
    {
        [TestMethod]
        public void Team_Constructor_InitializesPropertiesCorrectly()
        {
            // Arrange
            Trainer trainer = new Trainer("Pep", "Guardiola", 1000000);
            List<Voetbalspeler> spelers = new List<Voetbalspeler>
            {
                new Voetbalspeler("Lionel", "Messi", "Aanvaller"),
                new Voetbalspeler("Kevin", "De Bruyne", "Middenvelder"),
                new Voetbalspeler("Virgil", "van Dijk", "Verdediger")
            };

            // Act
            Team team = new Team(trainer, spelers);

            // Assert
            Assert.AreEqual(trainer, team.Trainer);
            CollectionAssert.AreEqual(spelers, team.Spelers);
        }

        [TestMethod]
        public void Team_VoegSpelerToe_AddsSpelerToList()
        {
            // Arrange
            Trainer trainer = new Trainer("Jurgen", "Klopp", 900000);
            List<Voetbalspeler> spelers = new List<Voetbalspeler>
            {
                new Voetbalspeler("Mohamed", "Salah", "Aanvaller"),
                new Voetbalspeler("Sadio", "Mane", "Aanvaller")
            };
            Team team = new Team(trainer, spelers);

            Voetbalspeler nieuweSpeler = new Voetbalspeler("Roberto", "Firmino", "Aanvaller");

            // Act
            team.VoegSpelerToe(nieuweSpeler);

            // Assert
            CollectionAssert.Contains(team.Spelers, nieuweSpeler);
        }

        [TestMethod]
        public void Team_VoegSpelerToe_DoesNotAddExistingSpelerToList()
        {
            // Arrange
            Trainer trainer = new Trainer("Zinedine", "Zidane", 1500000);
            Voetbalspeler speler1 = new Voetbalspeler("Karim", "Benzema", "Aanvaller");
            Voetbalspeler speler2 = new Voetbalspeler("Luka", "Modric", "Middenvelder");
            List<Voetbalspeler> spelers = new List<Voetbalspeler> { speler1, speler2 };
            Team team = new Team(trainer, spelers);

            // Act
            team.VoegSpelerToe(speler1);

            // Assert
            Assert.AreEqual(2, team.Spelers.Count); // Count remains the same, as the same player should not be added again
        }

        [TestMethod]
        public void Team_ToString_ReturnsCorrectFormat()
        {
            // Arrange
            Trainer trainer = new Trainer("Thomas", "Tuchel", 1200000);
            List<Voetbalspeler> spelers = new List<Voetbalspeler>
            {
                new Voetbalspeler("Kylian", "Mbappe", "Aanvaller"),
                new Voetbalspeler("N'Golo", "Kante", "Middenvelder"),
                new Voetbalspeler("Thiago", "Silva", "Verdediger"),
                new Voetbalspeler("Keylor", "Navas", "Keeper")
            };
            Team team = new Team(trainer, spelers);

            // Act
            string result = team.ToString();

            // Assert
            StringAssert.Contains(result, $"Trainer: {trainer}");
            StringAssert.Contains(result, $"Aantal spelers: {spelers.Count}");
            StringAssert.Contains(result, $"Aantal verdedigers: {team.AantalVerdedigers}");
            StringAssert.Contains(result, $"Aantal aanvallers: {team.AantalAanvallers}");
            StringAssert.Contains(result, $"Aantal middenvelders: {team.AantalMiddenvelders}");
            StringAssert.Contains(result, $"Aantal keepers: {team.AantalKeepers}");
        }
    }
}