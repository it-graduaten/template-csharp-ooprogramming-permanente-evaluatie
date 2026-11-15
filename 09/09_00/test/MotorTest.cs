namespace test
{
    [TestClass]
    [TestCategory("Models")]
    public class MotorTest
    {
        [TestMethod]
        public void MotorInitialization_Successful()
        {
            // Arrange
            int expectedCilinderinhoud = 1500;
            int expectedPk = 200;

            // Act
            var motor = new Motor(expectedCilinderinhoud, expectedPk);

            // Assert
            Assert.IsNotNull(motor);
            Assert.AreEqual(expectedCilinderinhoud, motor.Cilinderinhoud);
            Assert.AreEqual(expectedPk, motor.Pk);
        }

        [TestMethod]
        public void SetAndGetCilinderinhoud_Successful()
        {
            // Arrange
            var motor = new Motor(1200, 1800);
            int expectedCilinderinhoud = 1400;

            // Act
            motor.Cilinderinhoud = expectedCilinderinhoud;
            var resultCilinderinhoud = motor.Cilinderinhoud;

            // Assert
            Assert.AreEqual(expectedCilinderinhoud, resultCilinderinhoud);
        }

        [TestMethod]
        public void SetAndgetPk_Successful()
        {
            // Arrange
            var motor = new Motor(1000, 150);
            int expectedPk = 180;

            // Act
            motor.Pk = expectedPk;
            var resultPk = motor.Pk;

            // Assert
            Assert.AreEqual(expectedPk, resultPk);
        }

        [TestMethod]
        public void ToString_ReturnsCorrectString()
        {
            // Arrange
            var motor = new Motor(2000, 250);

            // Act
            var result = motor.ToString();

            // Assert
            var expected = "Cilinderinhoud: 2000 - Pk: 250";
            Assert.AreEqual(expected, result);
        }

    }
}