using System;

namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class ZichtrekeningTests
    {
        [TestMethod]
        public void ZichtrekeningTest()
        {
            var zichtRek = new Zichtrekening("BE 1234", 200);
            Assert.IsNotNull(zichtRek);
            Assert.AreEqual("BE 1234", zichtRek.IbanNummer);
            Assert.AreEqual(200, zichtRek.Saldo);
            Assert.AreEqual(-100, zichtRek.Minimum);
            Assert.IsInstanceOfType(zichtRek, typeof(Zichtrekening));
            Assert.IsInstanceOfType(zichtRek, typeof(Bankrekening));
        }

        [TestMethod]
        [DataRow("BE04 1234 1234 4321", 100)]
        [DataRow("BE04 1124 1234 4321", 99.99)]
        [DataRow("BE04 8432 1234 4321", 25.5)]
        [DataRow("BE04 8432 1234 4321", 300)]
        public void ToStringTest(string iban, double saldo)
        {
            var rek = new Zichtrekening(iban, saldo);
            var output = rek.ToString();
            StringAssert.Contains(output, iban);
            StringAssert.Contains(output, saldo.ToString());
            StringAssert.Contains(output, "->");
            StringAssert.Contains(output, "euro");
            StringAssert.Contains(output, "minimum");
        }
    }
}