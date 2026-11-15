using consoleapp.Models;

namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class ZichtrekeningTest
    {
        [TestMethod]
        public void Zichtrekening_ConstructorZonderParameters_PropertiesHebbenCorrecteWaarden()
        {
            var zichtRek = new Zichtrekening("BE 1234", 200);
            Assert.IsNotNull(zichtRek);
            Assert.AreEqual("BE 1234", zichtRek.IbanNummer);
            Assert.AreEqual(200, zichtRek.Saldo);
            Assert.AreEqual(-100, zichtRek.Minimum);
        }

        [TestMethod]
        public void Zichtrekening_ErftVanRekening()
        {
            var rek = new Zichtrekening("BE 1234", 200);
            Assert.IsInstanceOfType(rek, typeof(Bankrekening));
        }

        [TestMethod]
        [DataRow("BE04 1234 1234 4321", 100)]
        [DataRow("BE04 1124 1234 4321", 99.99)]
        [DataRow("BE04 8432 1234 4321", 25.5)]
        [DataRow("BE04 8432 1234 4321", 300)]
        public void ToonGegevens_OutputBevatAlleWaarden(string iban, double saldo)
        {
            var rek = new Zichtrekening(iban, saldo);
            var output = rek.ToonGegevens().ToLower();
            StringAssert.Contains(output, iban.ToLower());
            StringAssert.Contains(output, saldo.ToString());
            StringAssert.Contains(output, "minimum");
        }
    }
}