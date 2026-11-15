using consoleapp.Models;

namespace test;

[TestClass]
[TestCategory("Models")]
public class BmiTest
{

    [TestMethod]
    public void Constructor_WaardenPropertiesHebbenCorrecteValues()
    {
        var bmi = new Bmi();
        Assert.IsNotNull(bmi, "De constructor geeft null terug.");
        Assert.IsTrue(string.IsNullOrEmpty(bmi.Naam), "De naam is niet leeg.");
        Assert.AreEqual(0.0, bmi.Lengte, "De lengte is niet 0.0.");
        Assert.AreEqual(0.0, bmi.Gewicht, "Het gewicht is niet 0.0.");
    }


    [TestMethod]
    public void BmiTest1()
    {
        var bmi = new Bmi("John", 15.5, 34.5);
        Assert.IsNotNull(bmi, "De constructor geeft null terug.");
        Assert.AreEqual("John", bmi.Naam, "De naam is niet John.");
        Assert.AreEqual(34.5, bmi.Lengte, "De lengte is niet 34.5.");
        Assert.AreEqual(15.5, bmi.Gewicht, "Het gewicht is niet 15.5.");
    }


    [DataTestMethod]
    [DataRow("John", 60.0, 1.2, 41.7)]
    [DataRow("Jef", 67.0, 1.8, 20.7)]
    [DataRow("Mike", 90.0, 1.0, 90.0)]
    public void BerekenBmiTest(string name, double weight, double length, double expected)
    {
        var bmi = new Bmi(name, weight, length);
        var result = bmi.BerekenBmi();
        Assert.AreEqual(name, bmi.Naam, $"De waarde van naam was niet {name} maar {bmi.Naam}.");
        Assert.AreEqual(expected, result, $"De waarde van de BMI was niet {expected} maar {result}.");
    }


    [TestMethod]
    public void ToonGegevensTest()
    {
        var bmi = new Bmi("John", 67.0, 1.8);
        var result = bmi.ToonGegevens();
        StringAssert.Contains(result, "John", $"Het resultaat bevat niet de naam John.");
        var options = new List<string>() { "1.8", "1,8" };
        Assert.IsTrue(options.Any(s => result.Contains(s)), $"Het resultaat bevat niet de lengte 1.8.");
        options = new List<string>() { "20.7", "20,7" };
        Assert.IsTrue(options.Any(s => result.Contains(s)), $"Het resultaat bevat niet de BMI 20.7.");
    }
}
