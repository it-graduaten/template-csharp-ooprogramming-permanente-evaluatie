using consoleapp.Models;

namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class SpaarrekeningTest
    {
        [TestMethod]
        public void Spaarrekening_ConstructorZonderParameters_PropertiesHebbenCorrecteWaarden()
        {
            var spRek = new Spaarrekening("BE12");
            Assert.IsNotNull(spRek);
            Assert.AreEqual("BE12", spRek.IbanNummer);
            Assert.AreEqual(0, spRek.Saldo);
            Assert.AreEqual(5, spRek.Percentage);
            Assert.AreEqual(0, spRek.Minimum);
        }

        [TestMethod]
        public void Spaarrekening_ErftVanRekening()
        {
            var spRek = new Spaarrekening("BE12");
            Assert.IsInstanceOfType(spRek, typeof(Bankrekening));
        }

        [TestMethod]
        public void ToonGegevens_OutputBevatAlleWaarden()
        {
            var spRek = new Spaarrekening("BE12");
            var output = spRek.ToonGegevens().ToLower();
            StringAssert.Contains(output, "percentage");
        }

        [TestMethod]
        public void SchrijfRentebij_SaldoIs300EnPercentageIs5_SaldoIs315()
        {
            var spRek = new Spaarrekening("BE12");
            spRek.Saldo = 300;
            spRek.Percentage = 5;
            spRek.SchrijfRentebij();
            Assert.AreEqual(315, spRek.Saldo);
        }
    }
}