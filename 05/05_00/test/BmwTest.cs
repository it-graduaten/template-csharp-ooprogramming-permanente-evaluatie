using System;

namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class BmwTest
    {
        [TestMethod]
        public void Bmw_Constructor_CreatesCorrectInstance()
        {
            var b = new Bmw("1-hbj-298", 500, 12500, 44);
            Assert.IsNotNull(b);
        }

        [TestMethod]
        public void Bmw_Constructor_InheritanceFromAuto()
        {
            var b = new Bmw("1-hbj-298", 500, 12500, 44);
            Assert.IsInstanceOfType(b, typeof(Bmw));
            Assert.IsInstanceOfType(b, typeof(Auto));
        }

        [TestMethod]
        public void Bmw_Rijden_AddsCorrectKm()
        {
            var b = new Bmw("1-hbj-298", 500, 12500, 44);
            b.Rijden(260);
            var output = b.ToString().ToLower();
            StringAssert.Contains(output, "760");
        }

        [TestMethod]
        public void Bmw_Rijden_SubtractsCorrectLiter()
        {
            var b = new Bmw("1-hbj-298", 500, 12500, 44);
            b.Rijden(260);
            var output = b.ToString().ToLower();
            StringAssert.Contains(output, "31");
        }

        [TestMethod]
        public void Bmw_ToString_CorrectOutput()
        {
            var b = new Bmw("1-hbj-298", 500, 12500, 44);
            var output = b.ToString().ToLower();
            StringAssert.Contains(output, "ik ben een");
            StringAssert.Contains(output, "bmw");
            StringAssert.Contains(output, "met nummerplaat");
            StringAssert.Contains(output, "1-hbj-298");
            StringAssert.Contains(output, "500");
            StringAssert.Contains(output, "km");
            StringAssert.Contains(output, "44");
            StringAssert.Contains(output, "liter");
            StringAssert.Contains(output, "kostprijs");
            StringAssert.Contains(output, "12500");
        }
    }
}