namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class DierenverblijfTest
    {
        [TestMethod]
        public void VoegMannetjeToe_Successful()
        {
            // Arrange
            var dierenverblijf = new Dierenverblijf();
            var mannetjesdier = new Dier("Lionel", "Leeuw", false);

            // Act
            var result = dierenverblijf.VoegMannetjeToe(mannetjesdier);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(mannetjesdier, dierenverblijf.Mannetjesdier);
        }

        [TestMethod]
        public void VoegVrouwtjeToe_Successful()
        {
            // Arrange
            var dierenverblijf = new Dierenverblijf();
            var vrouwtjesdier = new Dier("Simba", "Leeuw", false);

            // Act
            var result = dierenverblijf.VoegVrouwtjeToe(vrouwtjesdier);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(vrouwtjesdier, dierenverblijf.Vrouwtjesdier);
        }

        [TestMethod]
        public void MeldHoofdverzorgerAan_Successful()
        {
            // Arrange
            var dierenverblijf = new Dierenverblijf();
            var mannetjesdier = new Dier("Lionel", "Leeuw", false);
            var vrouwtjesdier = new Dier("Simba", "Leeuw", false);
            dierenverblijf.VoegMannetjeToe(mannetjesdier);
            dierenverblijf.VoegVrouwtjeToe(vrouwtjesdier);
            var hoofdverzorger = new Personeelslid("John", "Doe", false);

            // Act
            var result = dierenverblijf.MeldHoofdverzorgerAan(hoofdverzorger);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(hoofdverzorger, dierenverblijf.Hoofdverzorger);
        }

        [TestMethod]
        public void MeldHulpverzorgerAan_Successful()
        {
            // Arrange
            var dierenverblijf = new Dierenverblijf();
            var vrouwtjesdier = new Dier("Simba", "Leeuw", false);
            var mannetjesdier = new Dier("Lionel", "Leeuw", false);
            dierenverblijf.VoegMannetjeToe(mannetjesdier);
            dierenverblijf.VoegVrouwtjeToe(vrouwtjesdier);
            var hulpverzorger = new Personeelslid("Jane", "Smith", false);

            // Act
            var result = dierenverblijf.MeldHulpverzorgerAan(hulpverzorger);

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(hulpverzorger, dierenverblijf.Hulpverzorger);
        }

        [TestMethod]
        public void DierenVoeren_Successful()
        {
            // Arrange
            var dierenverblijf = new Dierenverblijf();
            var mannetjesdier = new Dier("Lionel", "Leeuw", false);
            var vrouwtjesdier = new Dier("Simba", "Leeuw", false);
            dierenverblijf.VoegMannetjeToe(mannetjesdier);
            dierenverblijf.VoegVrouwtjeToe(vrouwtjesdier);

            // Act
            var moment = DateTime.Now;
            dierenverblijf.DierenVoeren(moment);

            // Assert
            Assert.AreEqual(moment, mannetjesdier.LaatstGevoerd);
            Assert.AreEqual(moment, vrouwtjesdier.LaatstGevoerd);
        }

        [TestMethod]
        public void VoegMannetjeToe_Fails_IfDifferentDiersoortAlreadyPresent()
        {
            // Arrange
            var dierenverblijf = new Dierenverblijf();
            var mannetjesdier1 = new Dier("Lionel", "Leeuw", false);
            var vrouwtjesdier = new Dier("Rex", "Tijger", false);
            dierenverblijf.VoegVrouwtjeToe(vrouwtjesdier);

            // Act
            var result = dierenverblijf.VoegMannetjeToe(mannetjesdier1);

            // Assert
            Assert.IsFalse(result);
            Assert.AreEqual(vrouwtjesdier, dierenverblijf.Vrouwtjesdier);
            Assert.IsNull(dierenverblijf.Mannetjesdier);
        }

        [TestMethod]
        public void VoegVrouwtjeToe_Fails_IfDifferentDiersoortAlreadyPresent()
        {
            // Arrange
            var dierenverblijf = new Dierenverblijf();
            var mannetjesdier = new Dier("Simba", "Leeuw", false);
            var vrouwtjesdier2 = new Dier("Nala", "Tijger", false);
            dierenverblijf.VoegMannetjeToe(mannetjesdier);

            // Act
            var result = dierenverblijf.VoegVrouwtjeToe(vrouwtjesdier2);

            // Assert
            Assert.IsFalse(result);
            Assert.AreEqual(mannetjesdier, dierenverblijf.Mannetjesdier);
            Assert.IsNull(dierenverblijf.Vrouwtjesdier);
        }

        [TestMethod]
        public void MeldHoofdverzorgerAan_Fails_IfCaretakerIsInternAndDangerousAnimalsPresent()
        {
            // Arrange
            var dierenverblijf = new Dierenverblijf();
            var hoofdverzorger = new Personeelslid("John", "Doe", true);
            var mannetjesdier = new Dier("Lionel", "Leeuw", true);
            dierenverblijf.VoegMannetjeToe(mannetjesdier);

            // Act
            var result = dierenverblijf.MeldHoofdverzorgerAan(hoofdverzorger);

            // Assert
            Assert.IsFalse(result);
            Assert.IsNull(dierenverblijf.Hoofdverzorger);
        }

        [TestMethod]
        public void ToString_Method_ReturnsCorrectString()
        {
            // Arrange
            var dierenverblijf = new Dierenverblijf();
            var hoofdverzorger = new Personeelslid("John", "Doe", false);
            var hulpverzorger = new Personeelslid("Jane", "Smith", false);
            var mannetjesdier = new Dier("Lionel", "Leeuw", false);
            var vrouwtjesdier = new Dier("Simba", "Leeuw", false);
            dierenverblijf.VoegMannetjeToe(mannetjesdier);
            dierenverblijf.VoegVrouwtjeToe(vrouwtjesdier);
            dierenverblijf.MeldHoofdverzorgerAan(hoofdverzorger);
            dierenverblijf.MeldHulpverzorgerAan(hulpverzorger);

            // Act
            var result = dierenverblijf.ToString();

            // Assert
            StringAssert.Contains(result, "Verzorgers");
            StringAssert.Contains(result, "Hoofdverzorger: John Doe (Vaste medewerker)");
            StringAssert.Contains(result, "Hulpverzorger: Jane Smith (Vaste medewerker)");
            StringAssert.Contains(result, "Dieren");
            StringAssert.Contains(result, "Mannetjesdier: Lionel (Leeuw) (Laatst gevoerd: " + mannetjesdier.LaatstGevoerd.ToShortTimeString() + ")");
            StringAssert.Contains(result, "Vrouwtjesdier: Simba (Leeuw) (Laatst gevoerd: " + vrouwtjesdier.LaatstGevoerd.ToShortTimeString() + ")");
        }
    }
}