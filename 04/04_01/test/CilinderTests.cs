using consoleapp.Models;

namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class CilinderTests
    {
        [TestMethod]
        [DataRow(5, 6, 4, 4)]
        [DataRow(10, 2, 5, 9)]
        [DataRow(0, 0, 9, 20)]
        public void Cilinder_ConstructorMet4Parameters_PropertiesHebbenCorrecteWaarden(double x, double y, double r, double h)
        {
            var c = new Cilinder(x, y, r, h);
            Assert.IsNotNull(c);
            Assert.AreEqual(x, c.X);
            Assert.AreEqual(y, c.Y);
            Assert.AreEqual(r, c.R);
            var omschrijving = c.Omschrijving.ToLower();
            StringAssert.Contains(omschrijving, "cilinder");
            StringAssert.Contains(omschrijving, "coord");
            StringAssert.Contains(omschrijving, x.ToString());
            StringAssert.Contains(omschrijving, y.ToString());
            StringAssert.Contains(omschrijving, r.ToString());
            StringAssert.Contains(omschrijving, h.ToString());
            StringAssert.Contains(omschrijving, "straal");
            StringAssert.Contains(omschrijving, "hoogte");
        }

        [TestMethod]
        public void Cilinder_ConstructorZonderParameters_PropertiesHebbenCorrecteWaarden()
        {
            var c = new Cilinder();
            Assert.IsNotNull(c);
            Assert.AreEqual(0, c.X);
            Assert.AreEqual(0, c.Y);
            var omschrijving = c.Omschrijving.ToLower();
            StringAssert.Contains(omschrijving, "cilinder");
            StringAssert.Contains(omschrijving, "coord");
            StringAssert.Contains(omschrijving, "0");
            StringAssert.Contains(omschrijving, "straal");
            StringAssert.Contains(omschrijving, "hoogte");
        }

        [TestMethod]
        public void Cilinder_ErftOverVanCirkelEnPunt()
        {
            var c = new Cilinder();
            Assert.IsInstanceOfType(c, typeof(Punt));
            Assert.IsInstanceOfType(c, typeof(Cirkel));
        }

        [TestMethod]
        [DataRow(5, 6, 4, 4, 201.06)]
        [DataRow(10, 2, 5, 9, 439.86)]
        [DataRow(0, 0, 9, 20, 1639.94)]
        public void Oppervlakte_GeldigeProperties_OppervlakteGeeftCorrecteOutput(double x, double y, double r, double h, double expected)
        {
            var c = new Cilinder(x, y, r, h);
            Assert.AreEqual(expected, c.Oppervlakte(), 1);
        }

        [TestMethod]
        [DataRow(5, 6, 4, 4)]
        [DataRow(10, 2, 5, 9)]
        [DataRow(0, 0, 9, 20)]
        public void ToonGegevens_OutputBevatAlleWaarden(double x, double y, double r, double h)
        {
            var c = new Cilinder(x, y, r, h);
            var output = c.ToonGegevens().ToLower();
            StringAssert.Contains(output, x.ToString());
            StringAssert.Contains(output, y.ToString());
            StringAssert.Contains(output, r.ToString());
            StringAssert.Contains(output, h.ToString());
            StringAssert.Contains(output, "volume");
            StringAssert.Contains(output, "hoogte");
        }

        [TestMethod]
        [DataRow(5, 6, 4, 4, 201.08)]
        [DataRow(10, 2, 5, 9, 706.86)]
        [DataRow(0, 0, 9, 20, 5089.4)]
        public void Volume_GeldigeProperties_VolumeGeeftCorrecteOutput(double x, double y, double r, double h, double expected)
        {
            var c = new Cilinder(x, y, r, h);
            Assert.AreEqual(expected, c.Volume(), 1);
        }
    }
}