using System;
using System.Collections.Generic;

namespace CarrinhoCompras
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Produto(int id, string nome, decimal preco)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
        }
    }

    public class Carrinho
    {
        public List<Produto> Itens { get; set; }
        public string FormaPagamento { get; set; }

        public Carrinho()
        {
            Itens = new List<Produto>();
        }

        public void AdicionarProduto(Produto produto)
        {
            Itens.Add(produto);
        }

        public void RemoverProduto(int id)
        {
            Produto encontrado = null;
            foreach (var item in Itens)
            {
                if (item.Id == id)
                {
                    encontrado = item;
                    break;
                }
            }
            if (encontrado != null)
            {
                Itens.Remove(encontrado);
            }
        }

        public void VisualizarCarrinho()
        {
            Console.WriteLine("=== Carrinho de Compras ===");
            foreach (var item in Itens)
            {
                Console.WriteLine($"[{item.Id}] {item.Nome} - R$ {item.Preco:F2}");
            }
            Console.WriteLine($"Total: R$ {CalcularTotal():F2}");
            Console.WriteLine($"Pagamento: {FormaPagamento}");
        }

        public decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (var item in Itens)
            {
                total += item.Preco;
            }
            return total;
        }
    }

    class Program
    {
        static void Main()
        {
            Carrinho carrinho = new Carrinho();
            carrinho.AdicionarProduto(new Produto(1, "Monitor 24", 800.00m));
            carrinho.AdicionarProduto(new Produto(2, "Cabo HDMI", 45.00m));
            carrinho.AdicionarProduto(new Produto(3, "Headset", 200.00m));

            carrinho.RemoverProduto(2);
            carrinho.FormaPagamento = "PIX";

            carrinho.VisualizarCarrinho();
        }
    }
}
