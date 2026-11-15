using System;

namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class SpaarrekeningTests
    {
        [TestMethod]
        public void SpaarrekeningTest()
        {
            var spRek = new Spaarrekening("BE 1234");
            Assert.IsNotNull(spRek);
            Assert.AreEqual("BE 1234", spRek.IbanNummer);
            Assert.AreEqual(0, spRek.Saldo);
            Assert.AreEqual(15, spRek.Percentage);
            Assert.AreEqual(0, spRek.Minimum);
            Assert.IsInstanceOfType(spRek, typeof(Spaarrekening));
            Assert.IsInstanceOfType(spRek, typeof(Bankrekening));
        }

        [TestMethod]
        public void SchrijfRentebijTest()
        {
            var spRek = new Spaarrekening("BE 1234");
            spRek.Saldo = 300;
            spRek.Percentage = 5;
            spRek.SchrijfRentebij();
            Assert.AreEqual(315, spRek.Saldo);
        }

        [TestMethod]
        public void ToStringTest()
        {
            var spRek = new Spaarrekening("BE 1234");
            spRek.Saldo = 300;
            spRek.Percentage = 5;
            spRek.SchrijfRentebij();
            var output = spRek.ToString();
            StringAssert.Contains(output, "315");
            StringAssert.Contains(output, "->");
            StringAssert.Contains(output, "euro");
            StringAssert.Contains(output, "rentevoet");
            StringAssert.Contains(output, "5");
        }
    }
}