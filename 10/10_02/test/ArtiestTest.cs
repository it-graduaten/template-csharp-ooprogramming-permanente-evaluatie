using consoleapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class ArtiestTest
    {
        [TestMethod]
        public void Artiest_Constructor_InitializesPropertiesCorrectly()
        {
            // Arrange
            string verwachteNaam = "Paramore";
            string verwachtGenre = "poprock";
            double verwachtePrijs = 25000;

            // Act
            Artiest artiest = new Artiest(verwachteNaam, verwachtGenre, verwachtePrijs);

            // Assert
            Assert.AreEqual(verwachteNaam, artiest.Naam);
            Assert.AreEqual(verwachtGenre, artiest.Genre);
            Assert.AreEqual(verwachtePrijs, artiest.Prijs);
        }

        [TestMethod]
        public void Artiest_ToString_ReturnsCorrectFormat()
        {
            // Arrange
            string verwachteNaam = "Chvrches";
            string verwachtGenre = "alternatief";
            double verwachtePrijs = 15000;
            Artiest artiest = new Artiest(verwachteNaam, verwachtGenre, verwachtePrijs);

            // Act
            string resultaat = artiest.ToString();

            // Assert
            Assert.AreEqual($"{verwachteNaam} ({verwachtGenre})", resultaat);
        }

        [TestMethod]
        public void Artiest_Equals_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            string verwachteNaam = "Silverstein";
            string verwachtGenre = "indie rock";
            double verwachtePrijs = 10000;
            Artiest artiestA = new Artiest(verwachteNaam, verwachtGenre, verwachtePrijs);
            Artiest artiestB = new Artiest(verwachteNaam, verwachtGenre, verwachtePrijs);

            // Act & Assert
            Assert.IsTrue(artiestA.Equals(artiestB));
            Assert.IsTrue(artiestA.Equals((object)artiestB));
        }

        [TestMethod]
        public void Artiest_Equals_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            string verwachteNaam = "Silverstein";
            string verwachtGenre = "indie rock";
            double verwachtePrijs = 10000;
            Artiest artiestA = new Artiest(verwachteNaam, verwachtGenre, verwachtePrijs);

            verwachteNaam = "Billie eilish";
            Artiest artiestB = new Artiest(verwachteNaam, verwachtGenre, verwachtePrijs);

            // Act & Assert
            Assert.IsFalse(artiestA.Equals(artiestB));
            Assert.IsFalse(artiestA.Equals((object)artiestB));
        }

        [TestMethod]
        public void Artiest_GetHashCode_ReturnsSameHashCodeForEqualObjects()
        {
            // Arrange
            string verwachteNaam = "Silverstein";
            string verwachtGenre = "indie rock";
            double verwachtePrijs = 10000;
            Artiest artiestA = new Artiest(verwachteNaam, verwachtGenre, verwachtePrijs);
            Artiest artiestB = new Artiest(verwachteNaam, verwachtGenre, verwachtePrijs);

            //Act
            int codeA = artiestA.GetHashCode();
            int codeB = artiestB.GetHashCode();

            // Assert
            Assert.AreEqual(codeA, codeB);
        }

        [TestMethod]
        public void Artiest_GetHashCode_ReturnsDifferentHashCodeForDifferentObjects()
        {
            // Arrange
            string verwachteNaam = "Silverstein";
            string verwachtGenre = "indie rock";
            double verwachtePrijs = 10000;
            Artiest artiestA = new Artiest(verwachteNaam, verwachtGenre, verwachtePrijs);

            verwachteNaam = "Billie eilish";
            Artiest artiestB = new Artiest(verwachteNaam, verwachtGenre, verwachtePrijs);

            //Act
            int codeA = artiestA.GetHashCode();
            int codeB = artiestB.GetHashCode();

            // Assert
            Assert.AreNotEqual(codeA, codeB);
        }
    }
}