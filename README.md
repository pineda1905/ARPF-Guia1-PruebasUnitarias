# Guía 1: Pruebas Unitarias con MSTest y xUnit (.NET 8)

**Estudiante:** Anderson Pineda (ARPF)  
**Institución:** Escuela Especializada en Ingeniería ITCA-FEPADE / ESFE  
**Solución:** `ARPF.sln`  
**Repositorio:** [https://github.com/pineda1905/ARPF-Guia1-PruebasUnitarias](https://github.com/pineda1905/ARPF-Guia1-PruebasUnitarias)  

---

## 📋 Descripción del Proyecto

Este repositorio contiene el desarrollo e implementación rigurosa de pruebas unitarias en el ecosistema .NET utilizando dos de los frameworks de testing más utilizados en la industria: **MSTest** y **xUnit**, de acuerdo a los lineamientos y especificaciones de la Guía 1.

La solución cumple con la nomenclatura requerida basada en las iniciales del estudiante (`ARPF`):

```
ARPF/
├── ARPF.sln                                # Solución principal .NET
├── ARPF.Temperatura/                       # Biblioteca de clases (Ejercicio 1)
│   ├── TemperatureConverter.cs             # Métodos CelsiusToFahrenheit y FahrenheitToCelsius
│   └── ARPF.Temperatura.csproj
├── ARPF.Temperatura.UnitTestMSTest/        # Proyecto de Pruebas Unitarias MSTest
│   ├── TemperatureConverterTests.cs       # 8 casos de prueba unitaria con MSTest
│   └── ARPF.Temperatura.UnitTestMSTest.csproj
├── ARPF.Cadenas/                           # Biblioteca de clases (Ejercicio 2)
│   ├── StringManipulator.cs                # Métodos ReverseString y RemoveSpaces
│   └── ARPF.Cadenas.csproj
└── ARPF.Cadenas.UnitTestAppxUnit/          # Proyecto de Pruebas Unitarias xUnit
    ├── StringManipulatorTests.cs           # 14 casos de prueba unitaria con Fact y Theory
    └── ARPF.Cadenas.UnitTestAppxUnit.csproj
```

---

## 🧪 Detalle de los Ejercicios y Casos de Prueba

### Ejercicio 1: Convertidor de Temperatura (`ARPF.Temperatura`)
- **Framework de pruebas:** MSTest (`Microsoft.VisualStudio.TestTools.UnitTesting`)
- **Estructura AAA:** Arrange, Act, Assert implementado en cada método de prueba.

| ID Caso | Método Probado | Escenario / Entrada | Resultado Esperado | Framework |
|---|---|---|---|---|
| **CP01** | `CelsiusToFahrenheit` | Punto de congelación: `0 °C` | `32.0 °F` | MSTest |
| **CP02** | `CelsiusToFahrenheit` | Punto de ebullición: `100 °C` | `212.0 °F` | MSTest |
| **CP03** | `CelsiusToFahrenheit` | Temperatura de coincidencia: `-40 °C` | `-40.0 °F` | MSTest |
| **CP04** | `CelsiusToFahrenheit` | Temperatura corporal promedio: `37 °C` | `98.6 °F` | MSTest |
| **CP05** | `FahrenheitToCelsius` | Punto de congelación: `32 °F` | `0.0 °C` | MSTest |
| **CP06** | `FahrenheitToCelsius` | Punto de ebullición: `212 °F` | `100.0 °C` | MSTest |
| **CP07** | `FahrenheitToCelsius` | Temperatura de coincidencia: `-40 °F` | `-40.0 °C` | MSTest |
| **CP08** | `FahrenheitToCelsius` | Temperatura corporal: `98.6 °F` | `37.0 °C` | MSTest |

---

### Ejercicio 2: Manipulación de Cadenas (`ARPF.Cadenas`)
- **Framework de pruebas:** xUnit (`Xunit`)
- **Características:** Uso de pruebas simples `[Fact]` y pruebas parametrizadas `[Theory]` con datos dinámicos `[InlineData]`.

| ID Caso | Método Probado | Escenario / Entrada | Resultado Esperado | Tipo xUnit |
|---|---|---|---|---|
| **CP09** | `ReverseString` | Texto estándar: `"Hola Mundo"` | `"odnuM aloH"` | `[Fact]` |
| **CP10** | `ReverseString` | Palíndromo: `"reconocer"` | `"reconocer"` | `[Fact]` |
| **CP11** | `ReverseString` | Cadena vacía: `""` | `""` | `[Fact]` |
| **CP12** | `ReverseString` | Parámetro nulo: `null` | Lanza `ArgumentNullException` | `[Fact]` |
| **CP13** | `RemoveSpaces` | Frase con espacios: `"Hola Mundo .NET"` | `"HolaMundo.NET"` | `[Fact]` |
| **CP14** | `RemoveSpaces` | Espacios múltiples y bordes: `"  Pruebas   Unitarias   xUnit  "` | `"PruebasUnitariasxUnit"` | `[Fact]` |
| **CP15** | `RemoveSpaces` | Cadena sin espacios: `"CSharp8"` | `"CSharp8"` | `[Fact]` |
| **CP16** | `RemoveSpaces` | Parámetro nulo: `null` | Lanza `ArgumentNullException` | `[Fact]` |
| **CP17** | `ReverseString` | Datos múltiples: `"esfe"`, `"dotnet"`, `"12345"` | `"efse"`, `"tentod"`, `"54321"` | `[Theory]` |
| **CP18** | `RemoveSpaces` | Datos múltiples: `"a b c d"`, `"  espacios  "`, `"sin_espacio"` | `"abcd"`, `"espacios"`, `"sin_espacio"` | `[Theory]` |

---

## 🚀 Compilación y Ejecución de Pruebas

Para compilar toda la solución y ejecutar el conjunto completo de 22 pruebas unitarias:

```bash
# Restaurar dependencias y compilar
dotnet build ARPF.sln

# Ejecutar todas las pruebas de la solución
dotnet test ARPF.sln
```

### Resultados de la Ejecución:
- **ARPF.Temperatura.UnitTestMSTest:** 8 pruebas superadas (100% exitosas)
- **ARPF.Cadenas.UnitTestAppxUnit:** 14 pruebas superadas (100% exitosas)
- **Total:** 22 pruebas superadas sin errores ni omisiones.

---

## 📌 Documentación en Azure DevOps

Los 18 casos de prueba documentados en la tabla anterior están estructurados para su registro directo en **Azure DevOps** en el módulo de **Test Plans / Boards (Work Items - Test Case)**, detallando:
- **Título del Caso de Prueba**
- **Precondiciones**
- **Pasos detallados (Arrange, Act)**
- **Resultado Esperado (Assert)**
