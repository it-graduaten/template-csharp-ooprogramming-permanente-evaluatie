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
    public class MetingTest
    {
        [TestMethod]
        public void Constructor_ShouldSetPropertiesCorrectly()
        {
            // Arrange
            DateTime verwachtTijdstip = DateTime.Now;
            double gradenCelsius = 25;

            // Act
            Meting meting = new Meting(gradenCelsius);

            // Assert
            Assert.IsTrue(meting.Tijdstip.AddSeconds(1) > verwachtTijdstip && meting.Tijdstip.AddSeconds(-1) < verwachtTijdstip, $"Fout bij het instellen van het tijdstip. Verwachtte waarde tussen {meting.Tijdstip.AddSeconds(-1)} en {meting.Tijdstip.AddSeconds(1)}, daadwerkelijke waarde: {meting.Tijdstip}");
            Assert.AreEqual(gradenCelsius, meting.GradenCelsius, 0.001, $"Fout bij het instellen van graden Celsius. Verwachtte waarde: {gradenCelsius}, daadwerkelijke waarde: {meting.GradenCelsius}");
            Assert.AreEqual(TemperatuurConversies.ConverteerNaarGradenFahrenheit(gradenCelsius), meting.GradenFahrenheit, 0.001, $"Fout bij het instellen van graden Fahrenheit. Verwachtte waarde: {TemperatuurConversies.ConverteerNaarGradenFahrenheit(gradenCelsius)}, daadwerkelijke waarde: {meting.GradenFahrenheit}");
        }

        [TestMethod]
        public void ConstructorWithTimestamp_ShouldSetPropertiesCorrectly()
        {
            // Arrange
            DateTime verwachtTijdstip = new DateTime(2023, 1, 1, 12, 0, 0);
            double gradenCelsius = 20;

            // Act
            Meting meting = new Meting(verwachtTijdstip, gradenCelsius);

            // Assert
            Assert.AreEqual(verwachtTijdstip, meting.Tijdstip, $"Fout bij het instellen van het tijdstip. Verwachtte waarde: {verwachtTijdstip}, daadwerkelijke waarde: {meting.Tijdstip}");
            Assert.AreEqual(gradenCelsius, meting.GradenCelsius, 0.001, $"Fout bij het instellen van graden Celsius. Verwachtte waarde: {gradenCelsius}, daadwerkelijke waarde: {meting.GradenCelsius}");
            Assert.AreEqual(TemperatuurConversies.ConverteerNaarGradenFahrenheit(gradenCelsius), meting.GradenFahrenheit, 0.001, $"Fout bij het instellen van graden Fahrenheit. Verwachtte waarde: {TemperatuurConversies.ConverteerNaarGradenFahrenheit(gradenCelsius)}, daadwerkelijke waarde: {meting.GradenFahrenheit}");
        }

        [TestMethod]
        public void CustomConstructor_ShouldSetPropertiesCorrectly()
        {
            // Arrange
            DateTime verwachtTijdstip = new DateTime(2023, 1, 1, 12, 0, 0);
            double gradenFahrenheit = 68;
            double gradenCelsius = 20;

            // Act
            Meting meting = new Meting(verwachtTijdstip, gradenFahrenheit, gradenCelsius);

            // Assert
            Assert.AreEqual(verwachtTijdstip, meting.Tijdstip, $"Fout bij het instellen van het tijdstip. Verwachtte waarde: {verwachtTijdstip}, daadwerkelijke waarde: {meting.Tijdstip}");
            Assert.AreEqual(gradenCelsius, meting.GradenCelsius, 0.001, $"Fout bij het instellen van graden Celsius. Verwachtte waarde: {gradenCelsius}, daadwerkelijke waarde: {meting.GradenCelsius}");
            Assert.AreEqual(gradenFahrenheit, meting.GradenFahrenheit, 0.001, $"Fout bij het instellen van graden Fahrenheit. Verwachtte waarde: {gradenFahrenheit}, daadwerkelijke waarde: {meting.GradenFahrenheit}");
        }

        [TestMethod]
        public void ToonGegevens_ShouldReturnCorrectString()
        {
            // Arrange
            DateTime tijdstip = new DateTime(2023, 10, 10, 12, 0, 0);
            double gradenCelsius = 20;
            double gradenFahrenheit = 68;

            Meting meting = new Meting(tijdstip, gradenFahrenheit, gradenCelsius);

            // Act
            string resultaat = meting.ToonGegevens();

            // Assert
            string verwachteString = $"Op {tijdstip} werd er {gradenCelsius} graden Celsius en {gradenFahrenheit} graden Fahrenheit gemeten.";
            StringAssert.Contains(resultaat, verwachteString, $"Fout bij het genereren van de string. Verwachtte waarde: {verwachteString}. Deze werd niet gevonden in de daadwerkelijke waarde: {resultaat}");
        }
    }
}