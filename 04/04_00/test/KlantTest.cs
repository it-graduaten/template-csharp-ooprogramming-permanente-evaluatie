using System;
using consoleapp.Models;

namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class KlantTests
    {
        [TestMethod]
        public void Constructor_PropertiesHebbenCorrecteWaarden()
        {
            var k = new Klant("John", "Doe");
            Assert.IsInstanceOfType(k, typeof(Klant));
            Assert.AreEqual("John", k.Voornaam);
            Assert.AreEqual("Doe", k.Achternaam);
        }

        [TestMethod]
        public void KlantErftVanPersoon()
        {
            var k = new Klant("John", "Doe");
            Assert.IsInstanceOfType(k, typeof(Persoon));
        }

        [TestMethod]
        public void ToonGegevens_OutputBevatAlleWaarden()
        {
            var p = new Klant("John", "Doe");
            var output = p.ToonGegevens().ToLower();
            StringAssert.Contains(output, "john");
            StringAssert.Contains(output, "doe");
            StringAssert.Contains(output, "mijn naam is");
            StringAssert.Contains(output, "klanten code");
            StringAssert.Contains(output, "jd");
        }
    }
}