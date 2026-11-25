using System;
using System.Collections.Generic;

namespace SistemaPedidos
{
    public class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Produto(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }

    public class Pedido
    {
        public string Cliente { get; set; }
        public List<Produto> Produtos { get; set; }
        public string FormaPagamento { get; set; }

        public Pedido(string cliente)
        {
            Cliente = cliente;
            Produtos = new List<Produto>();
        }

        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
        }

        public decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (var item in Produtos)
            {
                total += item.Preco;
            }
            return total;
        }

        public void ExibirResumo()
        {
            Console.WriteLine($"Cliente: {Cliente}");
            Console.WriteLine("Produtos:");
            foreach (var p in Produtos)
            {
                Console.WriteLine($"- {p.Nome}: R$ {p.Preco:F2}");
            }
            Console.WriteLine($"Forma de Pagamento: {FormaPagamento}");
            Console.WriteLine($"Total: R$ {CalcularTotal():F2}");
        }
    }

    class Program
    {
        static void Main()
        {
            Pedido pedido = new Pedido("Carlos Silva");
            pedido.AdicionarProduto(new Produto("Teclado Mecânico", 250.00m));
            pedido.AdicionarProduto(new Produto("Mouse Gamer", 120.00m));
            pedido.FormaPagamento = "Cartão de Crédito";

            pedido.ExibirResumo();
        }
    }
}
