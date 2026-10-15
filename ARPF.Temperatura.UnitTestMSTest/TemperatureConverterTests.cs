using Microsoft.VisualStudio.TestTools.UnitTesting;
using ARPF.Temperatura;

namespace ARPF.Temperatura.UnitTestMSTest
{
    [TestClass]
    public class TemperatureConverterTests
    {
        [TestMethod]
        public void CelsiusToFahrenheit_PuntoCongelacion_Retorna32()
        {
            // Arrange
            TemperatureConverter converter = new TemperatureConverter();
            double celsius = 0.0;
            double esperado = 32.0;

            // Act
            double resultado = converter.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(esperado, resultado, 0.001);
        }

        [TestMethod]
        public void CelsiusToFahrenheit_PuntoEbullicion_Retorna212()
        {
            // Arrange
            TemperatureConverter converter = new TemperatureConverter();
            double celsius = 100.0;
            double esperado = 212.0;

            // Act
            double resultado = converter.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(esperado, resultado, 0.001);
        }

        [TestMethod]
        public void CelsiusToFahrenheit_TemperaturaNegativa_RetornaMenos40()
        {
            // Arrange
            TemperatureConverter converter = new TemperatureConverter();
            double celsius = -40.0;
            double esperado = -40.0;

            // Act
            double resultado = converter.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(esperado, resultado, 0.001);
        }

        [TestMethod]
        public void CelsiusToFahrenheit_TemperaturaCorporal_Retorna98Punto6()
        {
            // Arrange
            TemperatureConverter converter = new TemperatureConverter();
            double celsius = 37.0;
            double esperado = 98.6;

            // Act
            double resultado = converter.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(esperado, resultado, 0.001);
        }

        [TestMethod]
        public void FahrenheitToCelsius_PuntoCongelacion_RetornaCero()
        {
            // Arrange
            TemperatureConverter converter = new TemperatureConverter();
            double fahrenheit = 32.0;
            double esperado = 0.0;

            // Act
            double resultado = converter.FahrenheitToCelsius(fahrenheit);

            // Assert
            Assert.AreEqual(esperado, resultado, 0.001);
        }

        [TestMethod]
        public void FahrenheitToCelsius_PuntoEbullicion_Retorna100()
        {
            // Arrange
            TemperatureConverter converter = new TemperatureConverter();
            double fahrenheit = 212.0;
            double esperado = 100.0;

            // Act
            double resultado = converter.FahrenheitToCelsius(fahrenheit);

            // Assert
            Assert.AreEqual(esperado, resultado, 0.001);
        }

        [TestMethod]
        public void FahrenheitToCelsius_TemperaturaNegativa_RetornaMenos40()
        {
            // Arrange
            TemperatureConverter converter = new TemperatureConverter();
            double fahrenheit = -40.0;
            double esperado = -40.0;

            // Act
            double resultado = converter.FahrenheitToCelsius(fahrenheit);

            // Assert
            Assert.AreEqual(esperado, resultado, 0.001);
        }

        [TestMethod]
        public void FahrenheitToCelsius_TemperaturaCorporal_Retorna37()
        {
            // Arrange
            TemperatureConverter converter = new TemperatureConverter();
            double fahrenheit = 98.6;
            double esperado = 37.0;

            // Act
            double resultado = converter.FahrenheitToCelsius(fahrenheit);

            // Assert
            Assert.AreEqual(esperado, resultado, 0.001);
        }
    }
}
