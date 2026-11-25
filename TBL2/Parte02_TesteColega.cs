using System;

namespace Parte02_TesteColega
{
    public class UsuarioNaoAutenticadoException : Exception
    {
        public UsuarioNaoAutenticadoException(string mensagem) : base(mensagem) { }
    }

    public class SistemaColega
    {
        public bool UsuarioLogado { get; private set; }

        public void Login(string usuario, string senha)
        {
            if (usuario == "admin" && senha == "1234")
            {
                UsuarioLogado = true;
            }
        }

        public void AcessarRelatorioFinanceiro()
        {
            if (!UsuarioLogado)
            {
                throw new UsuarioNaoAutenticadoException("Acesso negado! É necessário fazer login para acessar este recurso.");
            }
            Console.WriteLine("Relatório financeiro exibido com sucesso.");
        }
    }

    class Program
    {
        static void Main()
        {
            SistemaColega sistema = new SistemaColega();

            Console.WriteLine("Teste 1: Tentando acessar recurso sem autenticar...");
            try
            {
                sistema.AcessarRelatorioFinanceiro();
            }
            catch (UsuarioNaoAutenticadoException ex)
            {
                Console.WriteLine($"Exceção capturada com sucesso: {ex.Message}");
            }

            Console.WriteLine("
Teste 2: Realizando login e acessando recurso...");
            try
            {
                sistema.Login("admin", "1234");
                sistema.AcessarRelatorioFinanceiro();
            }
            catch (UsuarioNaoAutenticadoException ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }
        }
    }
}
