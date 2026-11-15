using System;

namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class AudiTest
    {
        [TestMethod]
        public void Audi_Constructor_CreatesCorrectInstance()
        {
            var a = new Audi("1-lvn-568", 25000, 7500, 25);
            Assert.IsNotNull(a);
        }

        [TestMethod]
        public void Audi_Constructor_InheritanceFromAuto()
        {
            var a = new Audi("1-lvn-568", 25000, 7500, 25);
            Assert.IsInstanceOfType(a, typeof(Audi));
            Assert.IsInstanceOfType(a, typeof(Auto));
        }

        [TestMethod]
        public void Audi_Rijden_AddsCorrectKm()
        {
            var a = new Audi("1-lvn-568", 25000, 7500, 25);
            a.Rijden(30);
            var output = a.ToString().ToLower();
            StringAssert.Contains(output, "25030");
        }

        [TestMethod]
        public void Audi_Rijden_SubtractsCorrectLiter()
        {
            var a = new Audi("1-lvn-568", 25000, 7500, 25);
            a.Rijden(30);
            var output = a.ToString().ToLower();
            StringAssert.Contains(output, "23");
        }

        [TestMethod]
        public void Audi_ToString_CorrectOutput()
        {
            var a = new Audi("1-lvn-568", 25000, 7500, 25);
            var output = a.ToString().ToLower();
            StringAssert.Contains(output, "ik ben een");
            StringAssert.Contains(output, "audi");
            StringAssert.Contains(output, "met nummerplaat");
            StringAssert.Contains(output, "1-lvn-568");
            StringAssert.Contains(output, "25000");
            StringAssert.Contains(output, "km");
            StringAssert.Contains(output, "25");
            StringAssert.Contains(output, "liter");
            StringAssert.Contains(output, "kostprijs");
            StringAssert.Contains(output, "7500");
        }
    }
}
