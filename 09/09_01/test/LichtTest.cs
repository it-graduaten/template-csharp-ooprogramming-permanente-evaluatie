namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class LichtTest
    {
        [TestMethod]
        public void Constructor_PropertiesSetCorrectly()
        {
            var l = new Licht();
            Assert.IsNotNull(l);
            Assert.IsFalse(l.AanUit);
        }
    }
}