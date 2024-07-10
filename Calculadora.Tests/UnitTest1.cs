using Xunit;
// Certifique-se de que este using corresponda ao namespace correto
using Calculadora; // Exemplo de namespace ajustado

public class CalculadoraTests
{
    [Fact]
    public void TestSoma()
    {
        var calculadora = new CalculadoraOperations(); // Instancia a classe correta
        var resultado = calculadora.Soma(5, 3);
        Assert.Equal(8, resultado);
    }

    [Fact]
    public void TestSubtracao()
    {
        var calculadora = new CalculadoraOperations(); // Instancia a classe correta
        var resultado = calculadora.Subtracao(5, 3);
        Assert.Equal(2, resultado);
    }

    [Fact]
    public void TestMultiplicacao()
    {
        var calculadora = new CalculadoraOperations(); // Instancia a classe correta
        var resultado = calculadora.Multiplicacao(5, 3);
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void TestDivisao()
    {
        var calculadora = new CalculadoraOperations(); // Instancia a classe correta
        var resultado = calculadora.Divisao(5, 3);
        Assert.Equal(1.6666666666666667, resultado); // Considerando ponto flutuante
    }
}
