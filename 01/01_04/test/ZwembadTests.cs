using consoleapp.Models;

namespace test;

[TestClass]
[TestCategory("Models")]
public class ZwembadTests
{
    private readonly Zwembad _correctZ = new Zwembad(2, 1.8, 11, 0.3);
    private readonly Zwembad _incorrectZ = new Zwembad(-10, 5, -2, 4);

    [TestMethod]
    public void CorrectZwembadTest()
    {
        Assert.AreEqual(2, _correctZ.Breedte);
        Assert.AreEqual(1.8, _correctZ.Diepte);
        Assert.AreEqual(11, _correctZ.Lengte);
        Assert.AreEqual(0.3, _correctZ.Randafstand);
    }

    [TestMethod]
    public void IncorrectZwembadTest()
    {
        Assert.AreEqual(0, _incorrectZ.Breedte);
        Assert.AreEqual(5, _incorrectZ.Diepte);
        Assert.AreEqual(0, _incorrectZ.Lengte);
        Assert.AreEqual(4, _incorrectZ.Randafstand);
    }

    [TestMethod]
    public void ToonGegevensTest()
    {
        var output = _correctZ.ToonGegevens();
        StringAssert.Contains(output, "Breedte = 2");
        var options = new List<string>() { "Diepte = 1.8", "Diepte = 1,8" };
        Assert.IsTrue(options.Any(s => output.Contains(s)), "");
        StringAssert.Contains(output, "Lengte = 11");
        options = new List<string>() { "Randafstand = 0.3", "Randafstand = 0,3" };
        Assert.IsTrue(options.Any(s => output.Contains(s)), "");
        StringAssert.Contains(output, "Liters water = 33000");
    }

    [TestMethod]
    public void LiterWaterTest()
    {
        var output = _correctZ.LiterWater();
        Assert.AreEqual(33000, output);
    }
}