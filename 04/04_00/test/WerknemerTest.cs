using System;
using consoleapp.Models;

namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class WerknemerTest
    {
        [TestMethod]
        public void Werknemer_Constructor_PropertiesHebbenCorrecteWaarden()
        {
            var w = new Werknemer("John", "Doe");
            Assert.IsInstanceOfType(w, typeof(Werknemer));
            Assert.AreEqual("John", w.Voornaam);
            Assert.AreEqual("Doe", w.Achternaam);
            Assert.AreEqual(10.20, w.Loon);
        }

        [TestMethod]
        public void WerknemerErftVanPersoon()
        {
            var w = new Werknemer("John", "Doe");
            Assert.IsInstanceOfType(w, typeof(Persoon));
        }

        [TestMethod]
        public void ToonGegevens_OutputBevatAlleWaarden()
        {
            var w = new Werknemer("John", "Doe");
            var output = w.ToonGegevens().ToLower();
            StringAssert.Contains(output, "john");
            StringAssert.Contains(output, "doe");
            StringAssert.Contains(output, "mijn naam is");
            StringAssert.Contains(output, "en ik verdien");
            StringAssert.Contains(output, "10,2");
            StringAssert.Contains(output, "euro per uur");
        }
    }

}