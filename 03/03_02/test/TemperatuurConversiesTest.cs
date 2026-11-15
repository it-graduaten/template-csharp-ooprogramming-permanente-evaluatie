using consoleapp.Models;

namespace test
{
    [TestClass]
    [TestCategory("Models")]
    internal class TemperatuurConversiesTest
    {
        [TestMethod]
        public void ConverteerNaarGradenCelsius_ShouldConvertFahrenheitToCelsius()
        {
            // Arrange
            double gradenFahrenheit = 32; // Vriespunt in Fahrenheit

            // Act
            double resultaat = TemperatuurConversies.ConverteerNaarGradenCelsius(gradenFahrenheit);

            // Assert
            Assert.AreEqual(0, resultaat, 0.001, $"Fout bij het converteren van Fahrenheit naar Celsius. Verwachtte waarde: 0, daadwerkelijke waarde: {resultaat}");
        }

        [TestMethod]
        public void ConverteerNaarGradenFahrenheit_ShouldConvertCelsiusToFahrenheit()
        {
            // Arrange
            double gradenCelsius = 0; // Vriespunt in Celsius

            // Act
            double resultaat = TemperatuurConversies.ConverteerNaarGradenFahrenheit(gradenCelsius);

            // Assert
            Assert.AreEqual(32, resultaat, 0.001, $"Fout bij het converteren van Celsius naar Fahrenheit. Verwachtte waarde: 32, daadwerkelijke waarde: {resultaat}");
        }

        [TestMethod]
        public void ConverteerNaarGradenFahrenheit_ShouldHandleNegativeCelsiusValues()
        {
            // Arrange
            double gradenCelsius = -40; // -40 graden Celsius is gelijk aan -40 graden Fahrenheit

            // Act
            double resultaat = TemperatuurConversies.ConverteerNaarGradenFahrenheit(gradenCelsius);

            // Assert
            Assert.AreEqual(-40, resultaat, 0.001, $"Fout bij het converteren van Celsius naar Fahrenheit voor negatieve waarden. Verwachtte waarde: -40, daadwerkelijke waarde: {resultaat}");
        }
    }
}