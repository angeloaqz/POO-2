namespace AulaTestes.Tests;

public class CalculadoraIMCTests
{
    [Fact]
    public void Calcular_70e175_DeveRetornarAproximadamente22_86()
    {
        var calc = new CalculadoraIMC();
        var resultado = calc.Calcular(70, 1.75);
        Assert.Equal(22.86, resultado, 2);
    }

    [Fact]
    public void Classificar_17_DeveRetornarAbaixoDoPeso()
    {
        var calc = new CalculadoraIMC();
        Assert.Equal("Abaixo do peso", calc.Classificar(17));
    }

    [Fact]
    public void Classificar_26_DeveRetornarSobrepeso()
    {
        var calc = new CalculadoraIMC();
        Assert.Equal("Sobrepeso", calc.Classificar(26));
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1.5)]
    public void Calcular_DeveLancarExcecao_QuandoAlturaForMenorOuIgualAZero(double altura)
    {
        var calc = new CalculadoraIMC();
        var ex = Assert.Throws<ArgumentException>(() => calc.Calcular(70, altura));
        Assert.Equal("Altura deve ser maior que zero", ex.Message);
    }
}
