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
    public class FestivalTest
    {
        [TestMethod]
        public void Festival_Creation_Succeeds()
        {
            // Arrange
            Festival festival;

            // Act
            festival = new Festival("MyFestival", 10000);

            // Assert
            Assert.IsNotNull(festival);
            Assert.AreEqual("MyFestival", festival.Naam);
            Assert.AreEqual(10000, festival.Budget);
            Assert.IsNotNull(festival.Optredens);
            Assert.AreEqual(0, festival.Optredens.Count);
        }

        [TestMethod]
        public void VoegOptredenToe_ValidOptreden_Succeeds()
        {
            // Arrange
            Festival festival = new Festival("TestFestival", 5000);
            Artiest artist = new Artiest("TestArtist", "Genre", 2000);
            Optreden optreden = new Optreden(artist, "vrijdag");

            // Act
            festival.VoegOptredenToe(optreden);

            // Assert
            Assert.AreEqual(1, festival.Optredens.Count);
            Assert.IsTrue(festival.Optredens.Contains(optreden));
        }

        [TestMethod]
        public void VoegOptredenToe_DuplicateOptreden_Fails()
        {
            // Arrange
            Festival festival = new Festival("TestFestival", 5000);
            Artiest artist = new Artiest("TestArtist", "Genre", 2000);
            Optreden optreden = new Optreden(artist, "vrijdag");

            // Act
            festival.VoegOptredenToe(optreden);
            festival.VoegOptredenToe(optreden); // Attempt to add the same optreden again

            // Assert
            Assert.AreEqual(1, festival.Optredens.Count);
        }

        [TestMethod]
        public void VoegOptredenToe_ExceedBudget_Fails()
        {
            // Arrange
            Festival festival = new Festival("TestFestival", 5000);
            Artiest artist = new Artiest("ExpensiveArtist", "Genre", 10000);
            Optreden optreden = new Optreden(artist, "vrijdag");

            // Act
            festival.VoegOptredenToe(optreden);

            // Assert
            Assert.AreEqual(0, festival.Optredens.Count);
        }

        [TestMethod]
        public void VerwijderOptreden_ValidOptreden_Succeeds()
        {
            // Arrange
            Festival festival = new Festival("TestFestival", 5000);
            Artiest artist = new Artiest("TestArtist", "Genre", 2000);
            Optreden optreden = new Optreden(artist, "vrijdag");
            festival.VoegOptredenToe(optreden);

            // Act
            festival.VerwijderOptreden(optreden);

            // Assert
            Assert.AreEqual(0, festival.Optredens.Count);
        }

        [TestMethod]
        public void BerekenTotaleKost_NoOptreden_ReturnsZero()
        {
            // Arrange
            Festival festival = new Festival("TestFestival", 5000);

            // Act
            double totaleKost = festival.BerekenTotaleKost();

            // Assert
            Assert.AreEqual(0, totaleKost);
        }

        [TestMethod]
        public void ToonOptredenVanDag_ValidDag_ReturnsCorrectString()
        {
            // Arrange
            Festival festival = new Festival("TestFestival", 5000);
            Artiest artist1 = new Artiest("Artist1", "Genre", 1000);
            Artiest artist2 = new Artiest("Artist2", "Genre", 1500);
            Optreden optreden1 = new Optreden(artist1, "vrijdag");
            Optreden optreden2 = new Optreden(artist2, "zaterdag");
            festival.VoegOptredenToe(optreden1);
            festival.VoegOptredenToe(optreden2);

            // Act
            string result = festival.ToonOptredenVanDag("vrijdag");

            // Assert
            StringAssert.Contains(result, "Artist1");
        }

        [TestMethod]
        public void ToString_ReturnsExpectedString()
        {
            // Arrange
            Festival festival = new Festival("TestFestival", 5000);
            Artiest artist1 = new Artiest("Artist1", "Genre1", 1000);
            Optreden optreden1 = new Optreden(artist1, "vrijdag");
            festival.VoegOptredenToe(optreden1);

            // Act
            string result = festival.ToString();

            // Assert
            StringAssert.Contains(result, "TESTFESTIVAL");
            StringAssert.Contains(result, "Artist1");
            StringAssert.Contains(result, "vrijdag");
            StringAssert.Contains(result, "1000 euro");
        }
    }
}