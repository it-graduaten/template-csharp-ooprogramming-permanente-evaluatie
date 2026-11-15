using consoleapp.Models;

namespace test;

[TestClass]
[TestCategory("Models")]
public class TamagotchiTests
{


    [TestMethod]
    public void Constructor_PropertiesHebbenCorrecteWaarden()
    {
        Tamagotchi tamagotchi = new Tamagotchi("Tamagotchi");

        Assert.AreEqual("Tamagotchi", tamagotchi.Naam, $"Jouw waarde voor naam is {tama.Naam}, het zou Tamagotchi moeten zijn.");
        Assert.AreEqual(5, tamagotchi.Honger, $"Jouw waarde voor honger is {tama.Honger}, het zou 5 moeten zijn.");
        Assert.AreEqual(5, tamagotchi.GoedGevoel, $"Jouw waarde voor goed gevoel is {tama.GoedGevoel}, het zou 5 moeten zijn.");
    }

    [TestMethod]
    public void EtenTest()
    {
        Tamagotchi tamagotchi = new Tamagotchi("Tamagotchi");

        tamagotchi.Eten(2);
        Assert.AreEqual(7, tamagotchi.Honger, $"Jouw waarde voor honger is {tama.Honger}, het zou 7 moeten zijn.");
        Assert.IsTrue(tamagotchi.LaatsteMaaltijd >= DateTime.Now.AddSeconds(-5), $"De waarde voor laatste maaltijd is niet correct.");
        Assert.IsTrue(tamagotchi.LaatsteMaaltijd <= DateTime.Now.AddSeconds(5), $"De waarde voor laatste maaltijd is niet correct.");
    }

    [TestMethod]
    public void LiefkozenTest()
    {
        Tamagotchi tamagotchi = new Tamagotchi("Tamagotchi");

        tamagotchi.Liefkozen();
        Assert.AreEqual(6, tamagotchi.GoedGevoel, $"Jouw waarde voor goed gevoel is {tama.GoedGevoel}, het zou 6 moeten zijn.");
    }

    [TestMethod]
    public void StraffenTest()
    {
        Tamagotchi tamagotchi = new Tamagotchi("Tamagotchi");

        tamagotchi.Straffen(2);
        Assert.AreEqual(3, tamagotchi.GoedGevoel, $"Jouw waarde voor goed gevoel is {tama.GoedGevoel}, het zou 3 moeten zijn.");
    }

    [TestMethod]
    public void GevoelTest()
    {
        Tamagotchi tamagotchi = new Tamagotchi("Tamagotchi");

        string gevoel = tamagotchi.Gevoel();
        StringAssert.Contains(gevoel, "Gevoel = ", $"De Gevoel methode bevat niet de verwachte waarde 'Gevoel = '.");
        StringAssert.Contains(gevoel, "Honger = ", $"De Gevoel methode bevat niet de verwachte waarde 'Honger = '.");
        StringAssert.Contains(gevoel, "-", $"De Gevoel methode bevat niet de verwachte waarde '-'.");
    }
}
