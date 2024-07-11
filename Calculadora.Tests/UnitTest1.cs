// CalculadoraTest.cs
using System;
using Xunit;
using CalculadoraBasica;

public class CalculadoraBasicaTests
{
    [Fact]
    public void TestSoma()
    {
        var calculadora = new CalculadoraOperations();
        var resultado = calculadora.Soma(5, 3);
        Assert.Equal(8, resultado);
    }

    // Rest of the test methods...
}
