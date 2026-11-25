using System;

namespace Questao5_EstoqueInsuficiente
{
    public class EstoqueInsuficienteException : Exception
    {
        public EstoqueInsuficienteException(string mensagem) : base(mensagem) { }
    }

    public class Produto
    {
        public string Nome { get; set; }
        public int QuantidadeEstoque { get; set; }

        public Produto(string nome, int quantidadeInicial)
        {
            Nome = nome;
            QuantidadeEstoque = quantidadeInicial;
        }

        public void RetirarEstoque(int quantidade)
        {
            if (quantidade > QuantidadeEstoque)
            {
                throw new EstoqueInsuficienteException($"Estoque insuficiente para '{Nome}'. Disponível: {QuantidadeEstoque}, Solicitado: {quantidade}.");
            }
            QuantidadeEstoque -= quantidade;
            Console.WriteLine($"Retirada de {quantidade} unidades de '{Nome}' realizada. Restante: {QuantidadeEstoque}.");
        }
    }

    class Program
    {
        static void Main()
        {
            Produto produto = new Produto("Notebook", 5);

            try
            {
                produto.RetirarEstoque(2);
                produto.RetirarEstoque(10);
            }
            catch (EstoqueInsuficienteException ex)
            {
                Console.WriteLine($"Erro de estoque: {ex.Message}");
            }
        }
    }
}
