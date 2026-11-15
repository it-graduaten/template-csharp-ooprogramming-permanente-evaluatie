namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class VerwarmingTest
    {
        public void Constructor_PropertiesSetCorrectly()
        {
            var v = new Verwarming();
            Assert.IsNotNull(v);
            Assert.AreEqual(0, v.Graden);
            Assert.IsFalse(v.AanUit);
        }

    }
}