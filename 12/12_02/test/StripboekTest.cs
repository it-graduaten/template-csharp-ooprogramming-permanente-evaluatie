namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class StripboekTest
    {
        [TestMethod]
        public void Stripboek_Constructor_ValidValues()
        {
            // Arrange
            string stripboekName = "TestStripboek";
            double stripboekPrice = 15.0;
            string stripboekAuthor = "TestAuthor";
            int stripboekPages = 100;

            // Act
            Stripboek stripboek = new Stripboek(stripboekName, stripboekPrice, stripboekAuthor, stripboekPages);

            // Assert
            Assert.IsNotNull(stripboek);
            Assert.AreEqual(stripboekName, stripboek.Naam);
            Assert.AreEqual(stripboekPrice, stripboek.Prijs);
            Assert.AreEqual(stripboekAuthor, stripboek.Auteur);
            Assert.AreEqual(stripboekPages, stripboek.AantalPaginas);
        }

        [TestMethod]
        public void Stripboek_Constructor_EmptyAuteur_ThrowsLegeTekstueleWaardeException()
        {
            // Arrange
            string stripboekName = "TestStripboek";
            double stripboekPrice = 15.0;
            string stripboekAuthor = "";
            int stripboekPages = 100;

            // Act & Assert
            Assert.ThrowsException<LegeTekstueleWaardeException>(() => new Stripboek(stripboekName, stripboekPrice, stripboekAuthor, stripboekPages));
        }

        [TestMethod]
        public void Stripboek_Constructor_NegativeAantalPaginas_ThrowsNumeriekeWaardeOnderNulException()
        {
            // Arrange
            string stripboekName = "TestStripboek";
            double stripboekPrice = 15.0;
            string stripboekAuthor = "TestAuthor";
            int stripboekPages = -50;

            // Act & Assert
            Assert.ThrowsException<NumeriekeWaardeOnderNulException>(() => new Stripboek(stripboekName, stripboekPrice, stripboekAuthor, stripboekPages));
        }

        [TestMethod]
        public void Stripboek_Equals_SameStripboek_ReturnsTrue()
        {
            // Arrange
            string stripboekName = "TestStripboek";
            double stripboekPrice = 15.0;
            string stripboekAuthor = "TestAuthor";
            int stripboekPages = 100;
            Stripboek stripboek1 = new Stripboek(stripboekName, stripboekPrice, stripboekAuthor, stripboekPages);
            Stripboek stripboek2 = new Stripboek(stripboekName, stripboekPrice, stripboekAuthor, stripboekPages);

            // Act & Assert
            Assert.IsTrue(stripboek1.Equals(stripboek2));
        }

        [TestMethod]
        public void Stripboek_Equals_DifferentStripboeks_ReturnsFalse()
        {
            // Arrange
            string stripboekName1 = "TestStripboek1";
            double stripboekPrice1 = 15.0;
            string stripboekAuthor1 = "TestAuthor1";
            int stripboekPages1 = 100;
            string stripboekName2 = "TestStripboek2";
            double stripboekPrice2 = 20.0;
            string stripboekAuthor2 = "TestAuthor2";
            int stripboekPages2 = 120;
            Stripboek stripboek1 = new Stripboek(stripboekName1, stripboekPrice1, stripboekAuthor1, stripboekPages1);
            Stripboek stripboek2 = new Stripboek(stripboekName2, stripboekPrice2, stripboekAuthor2, stripboekPages2);

            // Act & Assert
            Assert.IsFalse(stripboek1.Equals(stripboek2));
        }

        [TestMethod]
        public void Stripboek_ToString_ReturnsCorrectString()
        {
            // Arrange
            string stripboekName = "TestStripboek";
            double stripboekPrice = 15.0;
            string stripboekAuthor = "TestAuthor";
            int stripboekPages = 100;
            Stripboek stripboek = new Stripboek(stripboekName, stripboekPrice, stripboekAuthor, stripboekPages);

            // Act
            string result = stripboek.ToonGegevens();

            // Assert
            StringAssert.Contains(result, "TestStripboek");
            StringAssert.Contains(result, "15");
            StringAssert.Contains(result, "TestAuthor");
            StringAssert.Contains(result, "100");
        }
    }
}