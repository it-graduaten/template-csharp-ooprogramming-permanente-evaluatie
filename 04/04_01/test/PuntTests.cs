using consoleapp.Models;

namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class PuntTests
    {
        [TestMethod]
        public void Punt_Constructor_PropertiesHebbenCorrecteWaarden()
        {
            // Arrange
            var p = new Punt(3, 4);

            // Act & Assert
            Assert.AreEqual(3, p.X);
            Assert.AreEqual(4, p.Y);
        }

        [TestMethod]
        public void Punt_Omschrijving_CorrecteOmschrijvingWordtTeruggegeven()
        {
            // Arrange
            var p = new Punt(3, 4);

            // Act
            var omschrijving = p.Omschrijving;

            // Assert
            StringAssert.Contains(omschrijving, "Punt");
            StringAssert.Contains(omschrijving, "coord=(3,4)");
        }

        [TestMethod]
        public void Punt_ToonGegevens_CorrecteGegevensWordenTeruggegeven()
        {
            // Arrange
            var p = new Punt(3, 4);

            // Act
            var gegevens = p.ToonGegevens();

            // Assert
            StringAssert.Contains(gegevens, "Punt");
            StringAssert.Contains(gegevens, "coord=(3,4)");
        }
    }
}