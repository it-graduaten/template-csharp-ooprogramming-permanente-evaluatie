using System;

namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class VolkswagenTests
    {
        [TestMethod]
        public void Volkswagen_Constructor_CreatesCorrectInstance()
        {
            var v = new Volkswagen("1-sej-454", 100000, 5500, 10);
            Assert.IsNotNull(v);
        }

        [TestMethod]
        public void Volkswagen_Constructor_InheritanceFromAuto()
        {
            var v = new Volkswagen("1-sej-454", 100000, 5500, 10);
            Assert.IsInstanceOfType(v, typeof(Volkswagen));
            Assert.IsInstanceOfType(v, typeof(Auto));
        }

        [TestMethod]
        public void Volkswagen_Rijden_AddsCorrectKm()
        {
            var v = new Volkswagen("1-sej-454", 100000, 5500, 50);
            v.Rijden(250);
            var output = v.ToString().ToLower();
            StringAssert.Contains(output, "100250");
        }

        [TestMethod]
        public void Volkswagen_Rijden_SubtractsCorrectLiter()
        {
            var v = new Volkswagen("1-sej-454", 100000, 5500, 50);
            v.Rijden(250);
            var output = v.ToString().ToLower();
            StringAssert.Contains(output, "40");
        }

        [TestMethod]
        public void Volkswagen_ToString_CorrectOutput()
        {
            var v = new Volkswagen("1-sej-454", 100000, 5500, 10);
            var output = v.ToString().ToLower();
            StringAssert.Contains(output, "ik ben een");
            StringAssert.Contains(output, "volkswagen");
            StringAssert.Contains(output, "met nummerplaat");
            StringAssert.Contains(output, "1-sej-454");
            StringAssert.Contains(output, "100000");
            StringAssert.Contains(output, "km");
            StringAssert.Contains(output, "10");
            StringAssert.Contains(output, "liter");
            StringAssert.Contains(output, "kostprijs");
            StringAssert.Contains(output, "5500");
        }
    }
}