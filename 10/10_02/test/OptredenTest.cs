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
    public class OptredenTest
    {
        [TestMethod]
        public void Optreden_Constructor_InitializesPropertiesCorrectly()
        {
            // Arrange
            string verwachteNaam = "Paramore";
            string verwachtGenre = "poprock";
            double verwachtePrijs = 25000;
            Artiest artiest = new Artiest(verwachteNaam, verwachtGenre, verwachtePrijs);
            string verwachteDag = "vrijdag";

            // Act
            Optreden optreden = new Optreden(artiest, verwachteDag);

            // Assert
            Assert.AreEqual(verwachteNaam, optreden.Artiest.Naam);
            Assert.AreEqual(verwachtGenre, optreden.Artiest.Genre);
            Assert.AreEqual(verwachtePrijs, optreden.Artiest.Prijs);
            Assert.AreEqual(verwachteDag, optreden.Dag);
        }

        [TestMethod]
        public void Optreden_Equals_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            string verwachteNaam = "Silverstein";
            string verwachtGenre = "indie rock";
            double verwachtePrijs = 10000;
            string verwachteDag = "zaterdag";
            Artiest artiestA = new Artiest(verwachteNaam, verwachtGenre, verwachtePrijs);
            Artiest artiestB = new Artiest(verwachteNaam, verwachtGenre, verwachtePrijs);
            Optreden optredenA = new Optreden(artiestA, verwachteDag);
            Optreden optredenB = new Optreden(artiestB, verwachteDag);

            // Act & Assert
            Assert.IsTrue(optredenA.Equals(optredenB));
            Assert.IsTrue(optredenA.Equals((object)optredenB));
        }

        [TestMethod]
        public void Optreden_Equals_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            string verwachteNaam = "Silverstein";
            string verwachtGenre = "indie rock";
            double verwachtePrijs = 10000;
            string verwachteDag = "zaterdag";
            Artiest artiestA = new Artiest(verwachteNaam, verwachtGenre, verwachtePrijs);
            Artiest artiestB = new Artiest(verwachteNaam, verwachtGenre, verwachtePrijs);
            Optreden optredenA = new Optreden(artiestA, verwachteDag);
            verwachteDag = "zondag";
            Optreden optredenB = new Optreden(artiestB, verwachteDag);

            // Act & Assert
            Assert.IsFalse(optredenA.Equals(optredenB));
            Assert.IsFalse(optredenA.Equals((object)optredenB));
        }

        [TestMethod]
        public void Optreden_GetHashCode_ReturnsSameHashCodeForEqualObjects()
        {
            // Arrange
            string verwachteNaam = "Silverstein";
            string verwachtGenre = "indie rock";
            double verwachtePrijs = 10000;
            string verwachteDag = "zaterdag";
            Artiest artiestA = new Artiest(verwachteNaam, verwachtGenre, verwachtePrijs);
            Artiest artiestB = new Artiest(verwachteNaam, verwachtGenre, verwachtePrijs);
            Optreden optredenA = new Optreden(artiestA, verwachteDag);
            Optreden optredenB = new Optreden(artiestB, verwachteDag);

            //Act
            int codeA = optredenA.GetHashCode();
            int codeB = optredenB.GetHashCode();

            // Assert
            Assert.AreEqual(codeA, codeB);
        }

        [TestMethod]
        public void Optreden_GetHashCode_ReturnsDifferentHashCodeForDifferentObjects()
        {
            // Arrange
            string verwachteNaam = "Silverstein";
            string verwachtGenre = "indie rock";
            double verwachtePrijs = 10000;
            string verwachteDag = "zaterdag";
            Artiest artiestA = new Artiest(verwachteNaam, verwachtGenre, verwachtePrijs);
            Artiest artiestB = new Artiest(verwachteNaam, verwachtGenre, verwachtePrijs);
            Optreden optredenA = new Optreden(artiestA, verwachteDag);
            verwachteDag = "zondag";
            Optreden optredenB = new Optreden(artiestB, verwachteDag);

            //Act
            int codeA = optredenA.GetHashCode();
            int codeB = optredenB.GetHashCode();

            // Assert
            Assert.AreNotEqual(codeA, codeB);
        }
    }
}