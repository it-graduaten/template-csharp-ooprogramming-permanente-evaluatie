using consoleapp.Models;

namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class BankrekeningTest
    {
        [TestMethod]
        [DataRow("BE04 1234 1234 4321", 100)]
        [DataRow("BE04 1124 1234 4321", 99.99)]
        [DataRow("BE04 8432 1234 4321", 25.5)]
        [DataRow("BE04 8432 1234 4532", 300)]
        public void Rekening_ConstructorMet2Parameters_PropertiesHebbenCorrecteWaarden(string iban, double saldo)
        {
            var rek = new Bankrekening(iban, saldo);
            Assert.AreEqual(saldo, rek.Saldo);
            Assert.AreEqual(iban, rek.IbanNummer);
            Assert.AreEqual(iban.Substring(0, 2), rek.LandCode);
            Assert.AreEqual(0, rek.Minimum);
        }

        [TestMethod]
        [DataRow("BE04 1234 1234 4321", 100, 30, 70)]
        [DataRow("BE04 1124 1234 4321", 99.99, 30, 69.99)]
        [DataRow("BE04 8432 1234 4321", 25.5, 5.5, 20)]
        [DataRow("BE04 8432 1234 4321", 25.5, 300, 0)]
        public void Afhalen_GeldigeParameters_NieuweSaldoIsCorrect(string iban, double saldo, double bedrag, double expected)
        {
            var rek = new Bankrekening(iban, saldo);
            rek.Afhalen(bedrag);
            Assert.AreEqual(expected, rek.Saldo);
        }

        [TestMethod]
        [DataRow("BE04 1234 1234 4321", 100, 30, 130)]
        [DataRow("BE04 1124 1234 4321", 99.99, 30, 129.99)]
        [DataRow("BE04 8432 1234 4321", 25.5, 5.5, 31)]
        [DataRow("BE04 8432 1234 4321", 25.5, 300, 325.5)]
        public void Storten_GeldigeParameters_NieuweSaldoIsCorrect(string iban, double saldo, double bedrag, double expected)
        {
            var rek = new Bankrekening(iban, saldo);
            rek.Storten(bedrag);
            Assert.AreEqual(expected, rek.Saldo);
        }

        [TestMethod]
        [DataRow("BE04 1234 1234 4321", 100)]
        [DataRow("BE04 1124 1234 4321", 99.99)]
        [DataRow("BE04 8432 1234 4321", 25.5)]
        [DataRow("BE04 8432 1234 4321", 300)]
        public void ToonGegevens_OutputBevatAlleWaarden(string iban, double saldo)
        {
            var rek = new Bankrekening(iban, saldo);
            var output = rek.ToonGegevens();
            StringAssert.Contains(output, iban);
            StringAssert.Contains(output, saldo.ToString());
        }
    }
}