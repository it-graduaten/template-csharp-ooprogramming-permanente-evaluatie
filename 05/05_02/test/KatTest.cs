namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class KatTests
    {
        private Kat d = new Kat("Minoes");

        [TestMethod]
        public void KatTest()
        {
            Assert.IsNotNull(d);
            Assert.IsInstanceOfType(d, typeof(Kat));
            Assert.IsInstanceOfType(d, typeof(Dier));
            Assert.AreEqual("Minoes", d.Naam);
            var gegevens = d.Gegevens.ToLower();
            StringAssert.Contains(gegevens, "mijn naam is");
            StringAssert.Contains(gegevens, "minoes");
            StringAssert.Contains(gegevens, "en ik ben een");
            StringAssert.Contains(gegevens, "kat");
        }

        [TestMethod]
        public void PratenTest()
        {
            var output = d.Praten("");
            Assert.AreEqual("MAAAUWWW!", output);
        }

        [TestMethod]
        public void StrelenTest()
        {
            var output = d.Strelen();
            Assert.AreEqual("RRR! RRRR! RRRRRRRR!", output);
        }
    }
}