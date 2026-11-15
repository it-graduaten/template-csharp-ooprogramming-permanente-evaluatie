using consoleapp.Models;

namespace test;

[TestClass]
[TestCategory("Models")]
public class ZwembadTests
{
    [TestMethod]
    public void BreedteTest()
    {
        Zwembad zwembad = new Zwembad(200, 20, 200, 5);
        zwembad.Breedte = -10;
        Assert.AreEqual(0, zwembad.Breedte);
    }

    [TestMethod]
    public void ConstructorTest()
    {
        Zwembad zwembad = new Zwembad(200, 20, 100, 5);
        Assert.AreEqual(200, zwembad.Breedte);
        Assert.AreEqual(20, zwembad.Diepte);
        Assert.AreEqual(100, zwembad.Lengte);
        Assert.AreEqual(5, zwembad.Randafstand);
    }

    [TestMethod]
    public void ToonGegevensTest()
    {
        Zwembad zwembad = new Zwembad(200, 20, 100, 5);
        string output = zwembad.ToonGegevens();
        StringAssert.Contains(output, "Breedte = 200");
        StringAssert.Contains(output, "Diepte = 20");
        StringAssert.Contains(output, "Lengte = 100");
        StringAssert.Contains(output, "Randafstand = 5");
    }
}