using System;

namespace Questao1_IdadeInvalida
{
    public class IdadeInvalidaException : Exception
    {
        public IdadeInvalidaException(string mensagem) : base(mensagem) { }
    }

    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            if (idade < 0 || idade > 120)
            {
                throw new IdadeInvalidaException($"Idade {idade} é inválida. A idade deve estar entre 0 e 120 anos.");
            }
            Nome = nome;
            Idade = idade;
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                Pessoa p1 = new Pessoa("Lucas", 25);
                Console.WriteLine($"Cadastrado: {p1.Nome}, {p1.Idade} anos.");

                Pessoa p2 = new Pessoa("João", 150);
                Console.WriteLine($"Cadastrado: {p2.Nome}, {p2.Idade} anos.");
            }
            catch (IdadeInvalidaException ex)
            {
                Console.WriteLine($"Erro de validação: {ex.Message}");
            }
        }
    }
}
