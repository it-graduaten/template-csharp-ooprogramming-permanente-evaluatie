namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class PapegaaiTests
    {
        private Papegaai d = new Papegaai("Riko");

        [TestMethod]
        public void PapegaaiTest()
        {
            Assert.IsNotNull(d);
            Assert.IsInstanceOfType(d, typeof(Papegaai));
            Assert.IsInstanceOfType(d, typeof(Dier));
            Assert.AreEqual("Riko", d.Naam);
            var gegevens = d.Gegevens.ToLower();
            StringAssert.Contains(gegevens, "mijn naam is");
            StringAssert.Contains(gegevens, "riko");
            StringAssert.Contains(gegevens, "en ik ben een");
            StringAssert.Contains(gegevens, "papegaai");
        }

        [TestMethod]
        public void PratenTest()
        {
            var output = d.Praten("Ik ben een papegaai!");
            StringAssert.Contains(output, "Krahh!");
            StringAssert.Contains(output, "Ik ben een papegaai!");
        }

        [TestMethod]
        public void StrelenTest()
        {
            var output = d.Strelen();
            Assert.AreEqual("Koko! koko! kokoooohh!", output);
        }
    }
}