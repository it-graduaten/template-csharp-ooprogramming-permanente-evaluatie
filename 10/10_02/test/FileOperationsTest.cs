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
    public class FileOperationsTest
    {
        [TestMethod]
        public void FileOperations_LeesFestivals_ReturnsCorrectList()
        {
            // Act
            List<Festival> festivals = FileOperations.LeesFestivals();

            // Assert
            Assert.AreEqual(2, festivals.Count);
            Assert.IsInstanceOfType(festivals[0], typeof(Festival));
        }

        [TestMethod]
        public void FileOperations_LeesOptredens_ReturnsCorrectList()
        {
            //Arrange
            string festival = "pukkelpop";
            // Act
            List<Optreden> optredens = FileOperations.LeesOptredensPerFestival(festival);

            // Assert
            Assert.AreEqual(6, optredens.Count);
            Assert.IsInstanceOfType(optredens[0], typeof(Optreden));
        }
    }
}
