namespace AulaTestes.Tests;

public class AssertsExemplosTests
{
    [Fact]
    public void DeveSomarCorretamente()
    {
        int resultado = 2 + 3;
        Assert.Equal(5, resultado);
    }

    [Fact]
    public void DeveComparerDecimaisComPrecisao()
    {
        double temperatura = 22.857;
        Assert.Equal(22.86, temperatura, 2);
    }

    [Fact]
    public void DeveRetornarValorDiferente()
    {
        int resultado = 10 - 5;
        Assert.NotEqual(0, resultado);
    }

    [Fact]
    public void DeveConterLetraNaSenha()
    {
        string senha = "Senha123";
        bool contemLetra = senha.Any(char.IsLetter);
        Assert.True(contemLetra);
    }

    [Fact]
    public void SenhaNaoPodeSerVazia()
    {
        string senha = "";
        bool vazia = string.IsNullOrEmpty(senha);
        Assert.False(!vazia);
    }

    [Fact]
    public void ObjetoNaoDeveExistirInicialmente()
    {
        object? obj = null;
        Assert.Null(obj);
    }

    [Fact]
    public void ObjetoDeveSerCriado()
    {
        var usuario = new { Nome = "Carlos" };
        Assert.NotNull(usuario);
    }

    [Fact]
    public void DeveConterTextoEsperado()
    {
        string mensagem = "Bem-vindo ao sistema";
        Assert.Contains("sistema", mensagem);
    }

    [Fact]
    public void NaoDeveConterPalavraErro()
    {
        string mensagem = "Operação concluída com sucesso";
        Assert.DoesNotContain("erro", mensagem);
    }

    [Fact]
    public void CarrinhoDeveComecarVazio()
    {
        var itens = new List<string>();
        Assert.Empty(itens);
    }

    [Fact]
    public void CarrinhoDeveConterItens()
    {
        var itens = new List<string> { "Arroz", "Feijão" };
        Assert.NotEmpty(itens);
    }

    [Fact]
    public void DeveConterApenasUmItem()
    {
        var itens = new List<string> { "Produto A" };
        Assert.Single(itens);
    }

    [Fact]
    public void DeveLancarExcecaoAoDividirPorZero()
    {
        int zero = 0;
        Assert.Throws<DivideByZeroException>(() =>
        {
            int x = 10 / zero;
        });
    }

    [Fact]
    public void DeveVerificarMensagemDaExcecao()
    {
        var ex = Assert.Throws<ArgumentException>(() =>
        {
            throw new ArgumentException("Altura inválida");
        });
        Assert.Equal("Altura inválida", ex.Message);
    }

    [Fact]
    public void DeveSerDoTipoCorreto()
    {
        var texto = "Teste";
        Assert.IsType<string>(texto);
    }

    [Fact]
    public void IMCDeveEstarDentroDoIntervaloNormal()
    {
        double imc = 22.8;
        Assert.InRange(imc, 18.5, 24.9);
    }

    [Fact]
    public void TodosOsValoresDevemSerPositivos()
    {
        var numeros = new List<int> { 1, 2, 3, 4 };
        Assert.All(numeros, n => Assert.True(n > 0));
    }
}
