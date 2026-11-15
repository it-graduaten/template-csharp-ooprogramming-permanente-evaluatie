using consoleapp.Models;

namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class CirkelTests
    {
        [TestMethod]
        [DataRow(5, 6, 4)]
        [DataRow(10, 2, 5)]
        [DataRow(0, 0, 9)]
        public void Cirkel_ConstructorMet3Properties_PropertiesHebbenCorrecteWaarden(double x, double y, double r)
        {
            var c = new Cirkel(x, y, r);
            Assert.IsNotNull(c);
            Assert.AreEqual(x, c.X);
            Assert.AreEqual(y, c.Y);
            Assert.AreEqual(r, c.R);
            var omschrijving = c.Omschrijving.ToLower();
            StringAssert.Contains(omschrijving, "cirkel");
            StringAssert.Contains(omschrijving, "coord");
            StringAssert.Contains(omschrijving, x.ToString());
            StringAssert.Contains(omschrijving, y.ToString());
            StringAssert.Contains(omschrijving, r.ToString());
            StringAssert.Contains(omschrijving, "straal");
        }

        [TestMethod]
        public void Cirkel_ConstructorZonderParameters_PropertiesHebbenCorrecteWaarden()
        {
            var c = new Cirkel();
            Assert.IsNotNull(c);
            Assert.AreEqual(0, c.X);
            Assert.AreEqual(0, c.Y);
            var omschrijving = c.Omschrijving.ToLower();
            StringAssert.Contains(omschrijving, "cirkel");
            StringAssert.Contains(omschrijving, "coord");
            StringAssert.Contains(omschrijving, "0");
            StringAssert.Contains(omschrijving, "straal");
        }

        [TestMethod]
        public void Cirkel_ErftOverVanPunt()
        {
            var c = new Cirkel();
            Assert.IsInstanceOfType(c, typeof(Punt));
        }

        [TestMethod]
        [DataRow(5, 6, 20, 125.66)]
        [DataRow(10, 2, 5, 31.42)]
        [DataRow(0, 0, 9, 56.55)]
        public void Omtrek_GeldigeProperties_OmtrekIsCorrect(double x, double y, double r, double expected)
        {
            var c = new Cirkel(x, y, r);
            Assert.AreEqual(expected, c.Omtrek(), 1);
        }

        [TestMethod]
        [DataRow(5, 6, 20, 1256.64)]
        [DataRow(10, 2, 5, 78.54)]
        [DataRow(0, 0, 9, 254.47)]
        public void Oppervlakte_GeldigeProperties_OppervlakteIsCorrect(double x, double y, double r, double expected)
        {
            var c = new Cirkel(x, y, r);
            Assert.AreEqual(expected, c.Oppervlakte(), 1);
        }

        [TestMethod]
        [DataRow(5, 6, 20)]
        [DataRow(10, 2, 5)]
        [DataRow(0, 0, 9)]
        public void ToonGegevens_OutputBevatAlleWaarden(double x, double y, double r)
        {
            var c = new Cirkel(x, y, r);
            var output = c.ToonGegevens();
            StringAssert.Contains(output, x.ToString());
            StringAssert.Contains(output, y.ToString());
        }
    }
}