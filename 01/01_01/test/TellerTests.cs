using consoleapp.Models;

namespace test;

[TestClass]
[TestCategory("Models")]
public class TellerTests
{

    [TestMethod]
    public void Constructor_WaardeGelijkAan0()
    {
        var teller = new Teller();
        Assert.AreEqual(0, teller.Waarde, $"Jouw waarde van teller is {teller.Waarde}, het zou 0 moeten zijn.");
    }


    [TestMethod]
    public void Verhoog_NieuweTeller_WaardeGelijkAan1()
    {
        var teller = new Teller();
        teller.Verhoog();
        Assert.AreEqual(1, teller.Waarde, $"Jouw waarde van teller is {teller.Waarde}, het zou 1 moeten zijn.");
    }


    [TestMethod]
    public void Verlaag_NieuweTeller_WaardeGelijkAanMin1()
    {
        var teller = new Teller();
        teller.Verlaag();
        Assert.AreEqual(-1, teller.Waarde, $"Jouw waarde van teller is {teller.Waarde}, het zou -1 moeten zijn.");
    }


    [TestMethod]
    public void Resetten_NieuweTeller_WaardeGelijkAan0()
    {
        var teller = new Teller();
        teller.Verhoog();
        teller.Verhoog();
        teller.Verhoog();
        teller.Resetten();
        Assert.AreEqual(0, teller.Waarde, $"Jouw waarde van teller is {teller.Waarde}, het zou 0 moeten zijn.");
    }


    [TestMethod]
    public void ToonGegevens_NieuweTeller_GeeftCorrecteString()
    {
        var teller = new Teller();
        StringAssert.Contains(teller.ToonGegevens(), "De waarde van de teller is 0", $"Jouw ToonGegevens methode geeft {teller.ToonGegevens()} terug, het zou 'De waarde van de teller is 0' moeten zijn.");
    }
}
