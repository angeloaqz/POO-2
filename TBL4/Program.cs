using System;
using NLog;

namespace TBL4_Logging
{
    public class Conta
    {
        public int Numero { get; set; }
        public decimal Saldo { get; private set; }

        public Conta(int numero, decimal saldoInicial)
        {
            Numero = numero;
            Saldo = saldoInicial;
        }

        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("Valor de depósito deve ser maior que zero.");
            }
            Saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("Valor de saque deve ser maior que zero.");
            }
            if (Saldo < valor)
            {
                throw new InvalidOperationException("Saldo insuficiente para realizar o saque.");
            }
            Saldo -= valor;
        }

        public void Transferir(Conta destino, decimal valor)
        {
            Sacar(valor);
            destino.Depositar(valor);
        }
    }

    class Program
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        static void Main()
        {
            logger.Info("Início do programa");

            ConverterValor("123");
            ConverterValor("abc");

            Conta conta1 = new Conta(101, 500m);
            Conta conta2 = new Conta(202, 200m);

            RealizarDeposito(conta1, 150m);
            RealizarDeposito(conta1, -50m);

            RealizarSaque(conta1, 200m);
            RealizarSaque(conta1, 1000m);

            RealizarTransferencia(conta1, conta2, 100m);
            RealizarTransferencia(conta1, conta2, 900m);

            logger.Info("Fim do programa");
            LogManager.Shutdown();
        }

        static void ConverterValor(string texto)
        {
            try
            {
                logger.Info("Tentando converter texto '{0}' para inteiro", texto);
                int numero = int.Parse(texto);
                logger.Info("Conversão realizada com sucesso: {0}", numero);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Erro ao converter o valor '{0}' para inteiro", texto);
            }
        }

        static void RealizarDeposito(Conta conta, decimal valor)
        {
            logger.Info("Iniciando depósito de R$ {0} na conta {1}", valor, conta.Numero);
            try
            {
                conta.Depositar(valor);
                logger.Info("Depósito concluído com sucesso. Novo saldo da conta {0}: R$ {1}", conta.Numero, conta.Saldo);
            }
            catch (ArgumentException ex)
            {
                logger.Warn("Tentativa inválida de depósito na conta {0}: {1}", conta.Numero, ex.Message);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Erro inesperado ao depositar na conta {0}", conta.Numero);
            }
        }

        static void RealizarSaque(Conta conta, decimal valor)
        {
            logger.Info("Iniciando saque de R$ {0} na conta {1}", valor, conta.Numero);
            try
            {
                conta.Sacar(valor);
                logger.Info("Saque concluído com sucesso. Novo saldo da conta {0}: R$ {1}", conta.Numero, conta.Saldo);
            }
            catch (ArgumentException ex)
            {
                logger.Warn("Tentativa inválida de saque na conta {0}: {1}", conta.Numero, ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                logger.Error(ex, "Erro de saldo insuficiente ao sacar R$ {0} da conta {1}", valor, conta.Numero);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Erro inesperado ao sacar da conta {0}", conta.Numero);
            }
        }

        static void RealizarTransferencia(Conta origem, Conta destino, decimal valor)
        {
            logger.Info("Iniciando transferência de R$ {0} da conta {1} para a conta {2}", valor, origem.Numero, destino.Numero);
            try
            {
                origem.Transferir(destino, valor);
                logger.Info("Transferência concluída com sucesso. Saldo origem: R$ {0} | Saldo destino: R$ {1}", origem.Saldo, destino.Saldo);
            }
            catch (ArgumentException ex)
            {
                logger.Warn("Tentativa inválida de transferência da conta {0}: {1}", origem.Numero, ex.Message);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Erro ao transferir R$ {0} da conta {1} para a conta {2}", valor, origem.Numero, destino.Numero);
            }
        }
    }
}
