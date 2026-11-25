namespace AulaTestes.Tests;

public class CarrinhoTests
{
    [Fact]
    public void Adicionar_DeveSomarOTotalCorretamente()
    {
        var carrinho = new Carrinho();
        carrinho.Adicionar(new Item { Nome = "Arroz", Preco = 10.5 });
        carrinho.Adicionar(new Item { Nome = "Feijão", Preco = 20.5 });

        Assert.Equal(31, carrinho.Total(), 2);
    }

    [Fact]
    public void Limpar_DeveZerarOCarrinho()
    {
        var carrinho = new Carrinho();
        carrinho.Adicionar(new Item { Nome = "Arroz", Preco = 10 });
        carrinho.Adicionar(new Item { Nome = "Feijão", Preco = 20 });

        carrinho.Limpar();

        Assert.Equal(0, carrinho.Quantidade());
        Assert.Equal(0, carrinho.Total(), 2);
    }

    [Fact]
    public void Quantidade_DeveRetornarONumeroCorretoDeItens()
    {
        var carrinho = new Carrinho();
        carrinho.Adicionar(new Item { Nome = "Arroz", Preco = 10 });
        carrinho.Adicionar(new Item { Nome = "Feijão", Preco = 20 });
        carrinho.Adicionar(new Item { Nome = "Macarrão", Preco = 5 });

        Assert.Equal(3, carrinho.Quantidade());
    }
}
