namespace AulaTestes.Tests;

public class ValidadorSenhaTests
{
    [Fact]
    public void Senha123_DeveSerValida()
    {
        var validador = new ValidadorSenha();
        Assert.True(validador.EhValida("Senha123"));
    }

    [Fact]
    public void SomenteNumeros_DeveSerInvalida()
    {
        var validador = new ValidadorSenha();
        Assert.False(validador.EhValida("12345678"));
    }

    [Fact]
    public void SenhaVazia_DeveSerInvalida()
    {
        var validador = new ValidadorSenha();
        Assert.False(validador.EhValida(""));
    }

    [Fact]
    public void SomenteLetras_DeveSerInvalida()
    {
        var validador = new ValidadorSenha();
        Assert.False(validador.EhValida("abcdEFGH"));
    }
}
