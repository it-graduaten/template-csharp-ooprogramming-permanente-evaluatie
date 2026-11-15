using System;

namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class FileOperationsTest
    {
        [TestMethod]
        public void FileOperations_LeesStudenten_ReturnsCorrectAmountOfCursists()
        {
            List<Cursist> cursisten = FileOperations.LeesCursisten();
            Assert.IsNotNull(cursisten);
            Assert.AreEqual(12, cursisten.Count);
        }
    }
}