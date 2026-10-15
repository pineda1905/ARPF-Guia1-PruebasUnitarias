using System;
using Xunit;
using ARPF.Cadenas;

namespace ARPF.Cadenas.UnitTestAppxUnit
{
    public class StringManipulatorTests
    {
        [Fact]
        public void ReverseString_TextoNormal_RetornaTextoInvertido()
        {
            // Arrange
            StringManipulator manipulator = new StringManipulator();
            string texto = "Hola Mundo";
            string esperado = "odnuM aloH";

            // Act
            string resultado = manipulator.ReverseString(texto);

            // Assert
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void ReverseString_Palindromo_RetornaMismoTexto()
        {
            // Arrange
            StringManipulator manipulator = new StringManipulator();
            string texto = "reconocer";
            string esperado = "reconocer";

            // Act
            string resultado = manipulator.ReverseString(texto);

            // Assert
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void ReverseString_CadenaVacia_RetornaCadenaVacia()
        {
            // Arrange
            StringManipulator manipulator = new StringManipulator();
            string texto = string.Empty;
            string esperado = string.Empty;

            // Act
            string resultado = manipulator.ReverseString(texto);

            // Assert
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void ReverseString_ParametroNulo_LanzaArgumentNullException()
        {
            // Arrange
            StringManipulator manipulator = new StringManipulator();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => manipulator.ReverseString(null!));
        }

        [Fact]
        public void RemoveSpaces_TextoConEspacios_RetornaTextoSinEspacios()
        {
            // Arrange
            StringManipulator manipulator = new StringManipulator();
            string texto = "Hola Mundo .NET";
            string esperado = "HolaMundo.NET";

            // Act
            string resultado = manipulator.RemoveSpaces(texto);

            // Assert
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void RemoveSpaces_TextoConMultiplesEspacios_RetornaCadenaCompacta()
        {
            // Arrange
            StringManipulator manipulator = new StringManipulator();
            string texto = "  Pruebas   Unitarias   xUnit  ";
            string esperado = "PruebasUnitariasxUnit";

            // Act
            string resultado = manipulator.RemoveSpaces(texto);

            // Assert
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void RemoveSpaces_CadenaSinEspacios_RetornaMismaCadena()
        {
            // Arrange
            StringManipulator manipulator = new StringManipulator();
            string texto = "CSharp8";
            string esperado = "CSharp8";

            // Act
            string resultado = manipulator.RemoveSpaces(texto);

            // Assert
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void RemoveSpaces_ParametroNulo_LanzaArgumentNullException()
        {
            // Arrange
            StringManipulator manipulator = new StringManipulator();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => manipulator.RemoveSpaces(null!));
        }

        [Theory]
        [InlineData("esfe", "efse")]
        [InlineData("dotnet", "tentod")]
        [InlineData("12345", "54321")]
        public void ReverseString_CasosMultiples_RetornaInversionCorrecta(string original, string esperado)
        {
            // Arrange
            StringManipulator manipulator = new StringManipulator();

            // Act
            string resultado = manipulator.ReverseString(original);

            // Assert
            Assert.Equal(esperado, resultado);
        }

        [Theory]
        [InlineData("a b c d", "abcd")]
        [InlineData("  espacios  ", "espacios")]
        [InlineData("sin_espacio", "sin_espacio")]
        public void RemoveSpaces_CasosMultiples_RetornaSinEspacios(string original, string esperado)
        {
            // Arrange
            StringManipulator manipulator = new StringManipulator();

            // Act
            string resultado = manipulator.RemoveSpaces(original);

            // Assert
            Assert.Equal(esperado, resultado);
        }
    }
}
