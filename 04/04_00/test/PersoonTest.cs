using System;
using consoleapp.Models;

namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class PersoonTest
    {
        [TestMethod]
        public void ToonGegevens_OutputBevatCorrecteWaarden()
        {
            var p = new Klant("John", "Doe");
            var output = p.ToonGegevens().ToLower();
            StringAssert.Contains(output, "john");
            StringAssert.Contains(output, "doe");
            StringAssert.Contains(output, "mijn naam is");
        }
    }
}