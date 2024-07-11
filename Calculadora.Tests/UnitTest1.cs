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

    [Fact]
    public void TestSubtracao()
    {
        var calculadora = new CalculadoraOperations();
        var resultado = calculadora.Subtracao(5, 3);
        Assert.Equal(2, resultado);
    }

    [Fact]
    public void TestMultiplicacao()
    {
        var calculadora = new CalculadoraOperations();
        var resultado = calculadora.Multiplicacao(5, 3);
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void TestDivisao()
    {
        var calculadora = new CalculadoraOperations();
        var resultado = calculadora.Divisao(5, 3);
        Assert.Equal(1.6666666666666667, resultado, precision: 15); // Considerando ponto flutuante
    }

    [Fact]
    public void TestDivisaoPorZero()
    {
        var calculadora = new CalculadoraOperations();
        Assert.Throws<DivideByZeroException>(() => calculadora.Divisao(5, 0));
    }
}
