namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class KnuffelTest
    {
        [TestMethod]
        public void Knuffel_Constructor_ValidValues()
        {
            // Arrange
            string knuffelName = "TestKnuffel";
            double knuffelPrice = 20.0;
            double knuffelLength = 30.0;
            double knuffelWidth = 20.0;
            double knuffelHeight = 15.0;

            // Act
            Knuffel knuffel = new Knuffel(knuffelName, knuffelPrice, knuffelLength, knuffelWidth, knuffelHeight);

            // Assert
            Assert.IsNotNull(knuffel);
            Assert.AreEqual(knuffelName, knuffel.Naam);
            Assert.AreEqual(knuffelPrice, knuffel.Prijs);
            Assert.AreEqual(knuffelLength, knuffel.Lengte);
            Assert.AreEqual(knuffelWidth, knuffel.Breedte);
            Assert.AreEqual(knuffelHeight, knuffel.Hoogte);
        }

        [TestMethod]
        public void Knuffel_Constructor_NegativeLengte_ThrowsNumeriekeWaardeOnderNulException()
        {
            // Arrange
            string knuffelName = "TestKnuffel";
            double knuffelPrice = 20.0;
            double knuffelLength = -5.0;
            double knuffelWidth = 20.0;
            double knuffelHeight = 15.0;

            // Act & Assert
            Assert.ThrowsException<NumeriekeWaardeOnderNulException>(() => new Knuffel(knuffelName, knuffelPrice, knuffelLength, knuffelWidth, knuffelHeight));
        }

        [TestMethod]
        public void Knuffel_Constructor_NegativeBreedte_ThrowsNumeriekeWaardeOnderNulException()
        {
            // Arrange
            string knuffelName = "TestKnuffel";
            double knuffelPrice = 20.0;
            double knuffelLength = 30.0;
            double knuffelWidth = -5.0;
            double knuffelHeight = 15.0;

            // Act & Assert
            Assert.ThrowsException<NumeriekeWaardeOnderNulException>(() => new Knuffel(knuffelName, knuffelPrice, knuffelLength, knuffelWidth, knuffelHeight));
        }

        [TestMethod]
        public void Knuffel_Constructor_NegativeHoogte_ThrowsNumeriekeWaardeOnderNulException()
        {
            // Arrange
            string knuffelName = "TestKnuffel";
            double knuffelPrice = 20.0;
            double knuffelLength = 30.0;
            double knuffelWidth = 20.0;
            double knuffelHeight = -5.0;

            // Act & Assert
            Assert.ThrowsException<NumeriekeWaardeOnderNulException>(() => new Knuffel(knuffelName, knuffelPrice, knuffelLength, knuffelWidth, knuffelHeight));
        }

        [TestMethod]
        public void Knuffel_Equals_SameKnuffel_ReturnsTrue()
        {
            // Arrange
            string knuffelName = "TestKnuffel";
            double knuffelPrice = 20.0;
            double knuffelLength = 30.0;
            double knuffelWidth = 20.0;
            double knuffelHeight = 15.0;
            Knuffel knuffel1 = new Knuffel(knuffelName, knuffelPrice, knuffelLength, knuffelWidth, knuffelHeight);
            Knuffel knuffel2 = new Knuffel(knuffelName, knuffelPrice, knuffelLength, knuffelWidth, knuffelHeight);

            // Act & Assert
            Assert.IsTrue(knuffel1.Equals(knuffel2));
        }

        [TestMethod]
        public void Knuffel_Equals_DifferentKnuffels_ReturnsFalse()
        {
            // Arrange
            string knuffelName1 = "TestKnuffel1";
            double knuffelPrice1 = 20.0;
            double knuffelLength1 = 30.0;
            double knuffelWidth1 = 20.0;
            double knuffelHeight1 = 15.0;
            string knuffelName2 = "TestKnuffel2";
            double knuffelPrice2 = 25.0;
            double knuffelLength2 = 40.0;
            double knuffelWidth2 = 25.0;
            double knuffelHeight2 = 18.0;
            Knuffel knuffel1 = new Knuffel(knuffelName1, knuffelPrice1, knuffelLength1, knuffelWidth1, knuffelHeight1);
            Knuffel knuffel2 = new Knuffel(knuffelName2, knuffelPrice2, knuffelLength2, knuffelWidth2, knuffelHeight2);

            // Act & Assert
            Assert.IsFalse(knuffel1.Equals(knuffel2));
        }

        [TestMethod]
        public void Knuffel_ToString_ReturnsCorrectString()
        {
            // Arrange
            string knuffelName = "TestKnuffel";
            double knuffelPrice = 20.0;
            double knuffelLength = 30.0;
            double knuffelWidth = 20.0;
            double knuffelHeight = 15.0;
            Knuffel knuffel = new Knuffel(knuffelName, knuffelPrice, knuffelLength, knuffelWidth, knuffelHeight);

            // Act
            string result = knuffel.ToonGegevens();

            // Assert
            StringAssert.Contains(result, "TestKnuffel");
            StringAssert.Contains(result, "20");
            StringAssert.Contains(result, "30");
            StringAssert.Contains(result, "20");
            StringAssert.Contains(result, "15");
        }
    }
}