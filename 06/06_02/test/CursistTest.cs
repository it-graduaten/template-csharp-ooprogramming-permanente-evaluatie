using System;

namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class CursistTest
    {
        [TestMethod]
        public void Cursist_Constructor_CreatesCorrectInstance()
        {
            Cursist cursist = new Cursist(1, "Matthias", "Claessen");
            Assert.IsNotNull(cursist);
            Assert.AreEqual(1, cursist.CursistID);
            Assert.AreEqual("Matthias", cursist.Voornaam);
            Assert.AreEqual("Claessen", cursist.Familienaam);
            Assert.AreEqual("Matthias Claessen", cursist.Naam);
        }

        [TestMethod]
        public void Cursist_ToString_ReturnsCorrectString()
        {
            Cursist cursist = new Cursist(1, "Matthias", "Claessen");
            string output = cursist.ToString();
            StringAssert.Contains(output, "1.");
            StringAssert.Contains(output, "Matthias ");
            StringAssert.Contains(output, "Claessen");
        }
    }
}