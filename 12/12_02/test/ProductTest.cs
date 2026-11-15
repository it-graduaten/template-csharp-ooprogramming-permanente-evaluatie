namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class ProductTest
    {
        [TestMethod]
        public void Product_Constructor_ValidValues()
        {
            // Arrange
            string productName = "TestProduct";
            double productPrice = 50.0;

            // Act
            Product product = new Product(productName, productPrice);

            // Assert
            Assert.IsNotNull(product);
            Assert.AreEqual(productName, product.Naam);
            Assert.AreEqual(productPrice, product.Prijs);
        }

        [TestMethod]
        public void Product_Constructor_NullNaam_ThrowsLegeTekstueleWaardeException()
        {
            // Arrange
            string productName = null;
            double productPrice = 50.0;

            // Act & Assert
            Assert.ThrowsException<LegeTekstueleWaardeException>(() => new Product(productName, productPrice));
        }

        [TestMethod]
        public void Product_Constructor_EmptyNaam_ThrowsLegeTekstueleWaardeException()
        {
            // Arrange
            string productName = string.Empty;
            double productPrice = 50.0;

            // Act & Assert
            Assert.ThrowsException<LegeTekstueleWaardeException>(() => new Product(productName, productPrice));
        }

        [TestMethod]
        public void Product_Constructor_NegativePrijs_ThrowsNumeriekeWaardeOnderNulException()
        {
            // Arrange
            string productName = "TestProduct";
            double productPrice = -10.0;

            // Act & Assert
            Assert.ThrowsException<NumeriekeWaardeOnderNulException>(() => new Product(productName, productPrice));
        }

        [TestMethod]
        public void Product_Equals_SameProduct_ReturnsTrue()
        {
            // Arrange
            string productName = "TestProduct";
            double productPrice = 50.0;
            Product product1 = new Product(productName, productPrice);
            Product product2 = new Product(productName, productPrice);

            // Act & Assert
            Assert.IsTrue(product1.Equals(product2));
        }

        [TestMethod]
        public void Product_Equals_DifferentProducts_ReturnsFalse()
        {
            // Arrange
            string productName1 = "TestProduct1";
            double productPrice1 = 50.0;
            string productName2 = "TestProduct2";
            double productPrice2 = 75.0;
            Product product1 = new Product(productName1, productPrice1);
            Product product2 = new Product(productName2, productPrice2);

            // Act & Assert
            Assert.IsFalse(product1.Equals(product2));
        }

        [TestMethod]
        public void Product_ToString_ReturnsCorrectString()
        {
            // Arrange
            string productName = "TestProduct";
            double productPrice = 50.0;
            Product product = new Product(productName, productPrice);
            string expectedString = $"consoleapp.Models.Product {productName} ({productPrice})";

            // Act
            string result = product.ToString();

            // Assert
            StringAssert.Contains(result, productName);
            StringAssert.Contains(result, productPrice.ToString());
        }

        [TestMethod]
        public void Product_ToonGegevens_ReturnsCorrectString()
        {
            // Arrange
            string productName = "TestProduct";
            double productPrice = 50.0;
            Product product = new Product(productName, productPrice);

            // Act
            string result = product.ToonGegevens();

            // Assert
            StringAssert.Contains(result, "Naam");
            StringAssert.Contains(result, productName);
            StringAssert.Contains(result, "Prijs");
            StringAssert.Contains(result, productPrice.ToString());
        }
    }
}