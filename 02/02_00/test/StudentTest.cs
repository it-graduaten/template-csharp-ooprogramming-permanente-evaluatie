using consoleapp.Models;

namespace test;

[TestClass]
[TestCategory("Models")]
public class StudentTests
{
    [TestMethod]
    public void DefaultConstructor_PropertiesHebbenDefaultWaarden()
    {
        var student = new Student();
        Assert.AreEqual("", student.Naam, "De naam van de student is niet leeg.");
        Assert.AreEqual(0, student.ScoreProgrammeren, "De score voor programmeren is niet 0.");
        Assert.AreEqual(0, student.ScoreNetwerken, "De score voor netwerken is niet 0.");
    }

    [TestMethod]
    public void ConstructorMet3Params_PropertiesHebbenDeOpgegevenWaarden()
    {
        var student = new Student("Jan", 10, 12);
        Assert.AreEqual("Jan", student.Naam, "De naam van de student is niet Jan.");
        Assert.AreEqual(10, student.ScoreProgrammeren, "De score voor programmeren is niet 10.");
        Assert.AreEqual(12, student.ScoreNetwerken, "De score voor netwerken is niet 12.");
    }

    [DataTestMethod]
    [DataRow(-1, 0)]
    [DataRow(0, 0)]
    [DataRow(10, 10)]
    [DataRow(20, 20)]
    [DataRow(21, 20)]
    public void PropertyScoreProgrammeren_HeeftLimitaties(int value, int expected)
    {
        var student = new Student();
        student.ScoreProgrammeren = value;
        Assert.AreEqual(expected, student.ScoreProgrammeren, $"Jouw score voor programmeren is {student.ScoreProgrammeren}, het zou {expected} moeten zijn.");
    }

    [DataTestMethod]
    [DataRow(-1, 0)]
    [DataRow(0, 0)]
    [DataRow(10, 10)]
    [DataRow(20, 20)]
    [DataRow(21, 20)]
    public void PropertyScoreNetwerken_HeeftLimitaties(int value, int expected)
    {
        var student = new Student();
        student.ScoreNetwerken = value;
        Assert.AreEqual(expected, student.ScoreNetwerken, $"Jouw score voor netwerken is {student.ScoreNetwerken}, het zou {expected} moeten zijn.");
    }

    [TestMethod]
    public void VoerScoreProgrammerenIn_GeldigeWaarde_ScoreProgrammerenWordtGewijzigd()
    {
        var student = new Student();
        student.VoerScoreProgrammerenIn(10);
        Assert.AreEqual(10, student.ScoreProgrammeren, $"Jouw score voor programmeren is {student.ScoreProgrammeren}, het zou 10 moeten zijn.");
    }

    [TestMethod]
    public void VoerScoreNetwerkenIn_GeldigeWaarde_ScoreNetwerkenWordtGewijzigd()
    {
        var student = new Student();
        student.VoerScoreNetwerkenIn(10);
        Assert.AreEqual(10, student.ScoreNetwerken, $"Jouw score voor netwerken is {student.ScoreNetwerken}, het zou 10 moeten zijn.");
    }

    [DataTestMethod]
    [DataRow(0, 10, 10)]
    [DataRow(1, 10, 10)]
    [DataRow(0, 21, 20)]
    [DataRow(1, 21, 20)]
    [DataRow(0, -1, 0)]
    [DataRow(1, -1, 0)]
    public void VoerScoreIn_KeuzeMetGeldigeWaarde_ScoreWordtGewijzigd(int keuze, int score, int expectedScore)
    {
        var student = new Student();
        student.VoerScoreIn(keuze, score);
        if (keuze == 0)
            Assert.AreEqual(expectedScore, student.ScoreProgrammeren, $"Jouw score voor programmeren is {student.ScoreProgrammeren}, het zou {expectedScore} moeten zijn.");
        else
            Assert.AreEqual(expectedScore, student.ScoreNetwerken, $"Jouw score voor netwerken is {student.ScoreNetwerken}, het zou {expectedScore} moeten zijn.");
    }

    [DataTestMethod]
    [DataRow("Jan", 2, 2)]
    [DataRow("Jan", 2, 10)]
    [DataRow("Jan", 10, 2)]
    [DataRow("Jan", 10, 10)]
    [DataRow("Jan", 11, 11)]
    [DataRow("Jan", 20, 20)]
    public void ToonRapport_GeeftVerwachteStringTerug(string naam, int scoreProgrammeren, int scoreNetwerken)
    {
        var student = new Student(naam, scoreProgrammeren, scoreNetwerken);
        var output = student.ToonRapport();
        string bericht = (scoreProgrammeren >= 10 && scoreNetwerken >= 10) ? "Proficiat u bent geslaagd!" : "Helaas u bent niet geslaagd!";
        StringAssert.Contains(output, naam, $"Jouw ToonRapport methode geeft {output} terug, het zou {naam} moeten bevatten.");
        StringAssert.Contains(output, new string('-', naam.Length), $"Jouw ToonRapport methode geeft {output} terug, het zou {new string('-', naam.Length)} moeten bevatten.");
        StringAssert.Contains(output, $"Programmeren: {scoreProgrammeren}", $"Jouw ToonRapport methode geeft {output} terug, het zou {scoreProgrammeren} moeten bevatten.");
        StringAssert.Contains(output, $"Netwerken: {scoreNetwerken}", $"Jouw ToonRapport methode geeft {output} terug, het zou {scoreNetwerken} moeten bevatten.");
        StringAssert.Contains(output, bericht, $"Jouw ToonRapport methode geeft {output} terug, het zou {bericht} moeten bevatten.");
    }
}
