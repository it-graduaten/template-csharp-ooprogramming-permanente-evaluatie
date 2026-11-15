namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class OlifantTests
    {
        private Olifant d = new Olifant("Dumbo");

        [TestMethod]
        public void OlifantTest()
        {
            Assert.IsNotNull(d);
            Assert.IsInstanceOfType(d, typeof(Olifant));
            Assert.IsInstanceOfType(d, typeof(Dier));
            Assert.AreEqual("Dumbo", d.Naam);
            var gegevens = d.Gegevens.ToLower();
            StringAssert.Contains(gegevens, "mijn naam is");
            StringAssert.Contains(gegevens, "dumbo");
            StringAssert.Contains(gegevens, "en ik ben een");
            StringAssert.Contains(gegevens, "olifant");
        }

        [TestMethod]
        public void PratenTest()
        {
            var output = d.Praten("");
            Assert.AreEqual("Pfwwwwwww!", output);
        }

        [TestMethod]
        public void StrelenTest()
        {
            var output = d.Strelen();
            Assert.AreEqual("STOMP! STOMP! STOMP!", output);
        }
    }
}