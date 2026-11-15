namespace mstest;
using consoleapp.Models;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void AantalSpelers_3SpelersInTeam_Geeft3()
    {
        // Arrange
        Voetbalspeler speler1 = new Voetbalspeler("John", "Doe", "Middenvelder");
        Voetbalspeler speler2 = new Voetbalspeler("Jane", "Doe", "Aanvaller");
        Voetbalspeler speler3 = new Voetbalspeler("Guy", "Doe", "Keeper");
        Voetbalspeler speler4 = new Voetbalspeler("Guy", "Doe", "Keeper");
        Trainer trainer = new Trainer("Jef", "Doe", 1000);
        List<Voetbalspeler> spelers = new List<Voetbalspeler>() { speler1, speler2, speler3 };
        Team team = new Team(trainer, spelers);

        // Act
        int result = team.AantalSpelers;

        // Assert
        Assert.AreEqual(3, result);
    }

    public void AantalKeepers_TeamMet1Keeper_Geeft1()
    {

    }
}