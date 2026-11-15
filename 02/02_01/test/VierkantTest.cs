using consoleapp.Models;

namespace test;

[TestClass]
[TestCategory("Models")]
public class VierkantTests
{
    [DataTestMethod]
    [DataRow(5, 25)]
    [DataRow(3, 9)]
    public void OppervlakteTest(int zijde, int expected)
    {
        var v = new Vierkant();
        v.Zijde = zijde;
        Assert.AreEqual(expected, v.Oppervlakte(), $"De oppervlakte van een vierkant met zijde {zijde} is niet {expected} maar {v.Oppervlakte()}.");
    }

    [DataTestMethod]
    [DataRow(5, 7.07)]
    [DataRow(3, 4.24)]
    public void DiagonaalTest(int zijde, double expected)
    {
        var v = new Vierkant();
        v.Zijde = zijde;
        Assert.AreEqual(expected, v.Diagonaal(), $"De diagonaal van een vierkant met zijde {zijde} is niet {expected} maar {v.Diagonaal()}.");
    }

    [DataTestMethod]
    [DataRow(5, 20)]
    [DataRow(3, 12)]
    public void OmtrekTest(int zijde, int expected)
    {
        var v = new Vierkant();
        v.Zijde = zijde;
        Assert.AreEqual(expected, v.Omtrek(), $"De omtrek van een vierkant met zijde {zijde} is niet {expected} maar {v.Omtrek()}.");
    }

    [DataTestMethod]
    [DataRow(5, "* * * * *")]
    [DataRow(3, "* * *")]
    public void TekenTest(int zijde, string expected)
    {
        var v = new Vierkant();
        v.Zijde = zijde;

        StringAssert.Contains(v.Teken(), expected, $"Jouw teken methode bevat niet de verwachte waarde {expected}.");
    }

    [DataTestMethod]
    [DataRow(5, 25)]
    [DataRow(3, 9)]
    public void TekenTest2(int zijde, int expected)
    {
        var v = new Vierkant();
        v.Zijde = zijde;

        int freq = v.Teken().Count(f => (f == '*'));
        Assert.AreEqual(expected, freq, $"Jouw teken methode bevat niet het verwacht aantal sterren, namelijk: {expected}.");
    }

    [DataTestMethod]
    [DataRow(0, 0)]
    [DataRow(3, 3)]
    [DataRow(5, 5)]
    [DataRow(25, 25)]
    [DataRow(27, 25)]
    [DataRow(30, 25)]
    [DataRow(-3, 0)]
    [DataRow(-5, 0)]
    public void VierkantTest(int zijde, int expected)
    {
        var v = new Vierkant();
        v.Zijde = zijde;

        Assert.AreEqual(v.Zijde, expected, $"Jouw waarde voor zijde is {v.Zijde}, het zou {expected} moeten zijn.");
    }

    [DataTestMethod]
    [DataRow(0, 0)]
    [DataRow(3, 3)]
    [DataRow(5, 5)]
    [DataRow(25, 25)]
    [DataRow(27, 25)]
    [DataRow(30, 25)]
    [DataRow(-3, 0)]
    [DataRow(-5, 0)]
    public void VierkantTest1(int zijde, int expected)
    {
        var v = new Vierkant(zijde);
        Assert.AreEqual(v.Zijde, expected, $"Jouw waarde voor zijde is {v.Zijde}, het zou {expected} moeten zijn.");
    }
}