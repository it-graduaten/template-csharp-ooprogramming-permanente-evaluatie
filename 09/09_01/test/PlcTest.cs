namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class PlcTest
    {
        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public void DoeKeukenLichtAanTest(bool initialState)
        {
            var licht1 = new Licht();
            var licht2 = new Licht();
            var verwarming = new Verwarming();
            var plc = new Plc(licht1, licht2, verwarming);
            licht1.AanUit = initialState;

            plc.DoeKeukenLichtAan();
            Assert.IsTrue(plc.KeukenLicht.AanUit);
            Assert.IsTrue(licht1.AanUit);
            Assert.IsFalse(plc.WoonkamerLicht.AanUit);
            Assert.IsFalse(licht2.AanUit);
        }

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public void DoeKeukenLichtUitTest(bool initialState)
        {
            var licht1 = new Licht();
            var licht2 = new Licht();
            var verwarming = new Verwarming();
            var plc = new Plc(licht1, licht2, verwarming);
            licht1.AanUit = initialState;

            plc.DoeKeukenLichtUit();
            Assert.IsFalse(plc.KeukenLicht.AanUit);
            Assert.IsFalse(licht1.AanUit);
            Assert.IsFalse(plc.WoonkamerLicht.AanUit);
            Assert.IsFalse(licht2.AanUit);
        }

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public void DoeWoonkamerLichtAanTest(bool initialState)
        {
            var licht1 = new Licht();
            var licht2 = new Licht();
            var verwarming = new Verwarming();
            var plc = new Plc(licht1, licht2, verwarming);
            licht2.AanUit = initialState;

            plc.DoeWoonkamerLichtAan();
            Assert.IsFalse(plc.KeukenLicht.AanUit);
            Assert.IsFalse(licht1.AanUit);
            Assert.IsTrue(plc.WoonkamerLicht.AanUit);
            Assert.IsTrue(licht2.AanUit);
        }

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public void DoeWoonkamerLichtUitTest(bool initialState)
        {
            var licht1 = new Licht();
            var licht2 = new Licht();
            var verwarming = new Verwarming();
            var plc = new Plc(licht1, licht2, verwarming);
            licht2.AanUit = initialState;

            plc.DoeWoonkamerLichtUit();
            Assert.IsFalse(plc.KeukenLicht.AanUit);
            Assert.IsFalse(licht1.AanUit);
            Assert.IsFalse(plc.WoonkamerLicht.AanUit);
            Assert.IsFalse(licht2.AanUit);
        }

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public void ZetVerwarmingAanTest(bool initialState)
        {
            var licht1 = new Licht();
            var licht2 = new Licht();
            var verwarming = new Verwarming();
            var plc = new Plc(licht1, licht2, verwarming);
            verwarming.AanUit = initialState;

            plc.ZetVerwarmingAan();
            Assert.IsTrue(plc.Verwarming.AanUit);
            Assert.IsTrue(verwarming.AanUit);
        }

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public void ZetVerwarmingUitTest(bool initialState)
        {
            var licht1 = new Licht();
            var licht2 = new Licht();
            var verwarming = new Verwarming();
            var plc = new Plc(licht1, licht2, verwarming);
            verwarming.AanUit = initialState;

            plc.ZetVerwarmingUit();
            Assert.IsFalse(plc.Verwarming.AanUit);
            Assert.IsFalse(verwarming.AanUit);
        }

        [TestMethod]
        public void PasTemperatuurAanTest()
        {
            var licht1 = new Licht();
            var licht2 = new Licht();
            var verwarming = new Verwarming();
            var plc = new Plc(licht1, licht2, verwarming);

            plc.PasTemperatuurAan(20);
            Assert.AreEqual(20, plc.Verwarming.Graden);
            Assert.AreEqual(20, verwarming.Graden);
        }

        [TestMethod]
        public void Constructor_PropertiesSetCorrectly()
        {
            var licht1 = new Licht();
            var licht2 = new Licht();
            var verwarming = new Verwarming();
            var plc = new Plc(licht1, licht2, verwarming);

            Assert.AreEqual(licht1, plc.KeukenLicht);
            Assert.AreEqual(licht2, plc.WoonkamerLicht);
            Assert.AreEqual(verwarming, plc.Verwarming);
        }
    }
}