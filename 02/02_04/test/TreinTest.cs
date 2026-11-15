using consoleapp.Models;

namespace test;

[TestClass]
[TestCategory("Models")]
public class TreinTest
{
    [TestMethod]
    public void Constructor_PropertiesHebbenCorrecteWaarden()
    {
        Trein trein = new Trein();
        Assert.IsTrue(trein.DeurOpen, "De deur is niet open.");
        Assert.AreEqual(0, trein.Passagiers, $"Er zijn {trein.Passagiers} passagiers aan boord, maar er zouden er 0 moeten zijn.");
    }

    [TestMethod]
    public void AfstappenTest()
    {
        Trein trein = new Trein();

        trein.Afstappen(2);
        Assert.AreEqual(0, trein.Passagiers, $"Er zijn {trein.Passagiers} passagiers aan boord, maar er zouden er 0 moeten zijn.");
        trein.Opstappen(10);
        trein.Afstappen(4);
        Assert.AreEqual(6, trein.Passagiers, $"Er zijn {trein.Passagiers} passagiers aan boord, maar er zouden er 6 moeten zijn.");
    }

    [TestMethod]
    public void OpstappenTest()
    {
        Trein trein = new Trein();

        trein.Opstappen(5);
        Assert.AreEqual(5, trein.Passagiers, $"Er zijn {trein.Passagiers} passagiers aan boord, maar er zouden er 5 moeten zijn.");
        trein.Opstappen(3);
        Assert.AreEqual(8, trein.Passagiers, $"Er zijn {trein.Passagiers} passagiers aan boord, maar er zouden er 8 moeten zijn.");
    }

    [TestMethod]
    public void SluitDeurTest()
    {
        Trein trein = new Trein();

        trein.SluitDeur();
        Assert.IsFalse(trein.DeurOpen, "De deur is open. Ze zou gesloten moeten zijn.");
    }

    [TestMethod]
    public void StoppenTest()
    {
        Trein trein = new Trein();

        trein.Stoppen();
        Assert.AreEqual(0, trein.Snelheid, $"De snelheid is {trein.Snelheid} maar zou 0 moeten zijn.");
        Assert.IsTrue(trein.DeurOpen, "De deur is niet open.");
    }

    [TestMethod]
    public void VersnellenTest()
    {
        Trein trein = new Trein();
        trein.SluitDeur();

        trein.Versnellen(50);
        Assert.IsFalse(trein.DeurOpen, "De deur is open. Ze zou gesloten moeten zijn.");
        Assert.AreEqual(50, trein.Snelheid, $"De snelheid is {trein.Snelheid} maar zou 50 moeten zijn.");
    }

    [TestMethod]
    public void RemmenTest()
    {
        Trein trein = new Trein();
        trein.SluitDeur();

        trein.Versnellen(50);
        trein.Remmen(30);
        Assert.AreEqual(20, trein.Snelheid, $"De snelheid is {trein.Snelheid} maar zou 20 moeten zijn.");
    }

    [TestMethod]
    public void StandVanZakenTest()
    {
        Trein trein = new Trein();
        string output = trein.StandVanZaken();

        StringAssert.Contains(output, "Snelheid: ", $"De output bevat niet de tekst 'Snelheid: '");
        StringAssert.Contains(output, "Passagiers: ", $"De output bevat niet de tekst 'Passagiers: '");
        StringAssert.Contains(output, "Deuren: ", $"De output bevat niet de tekst 'Deuren: '");
    }
}
