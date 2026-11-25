using System;

namespace Questao4_DivisaoPorZero
{
    public class DivisaoPorZeroException : Exception
    {
        public DivisaoPorZeroException(string mensagem) : base(mensagem) { }
    }

    public class Calculadora
    {
        public double Dividir(double dividendo, double divisor)
        {
            if (divisor == 0)
            {
                throw new DivisaoPorZeroException("Não é possível dividir um número por zero.");
            }
            return dividendo / divisor;
        }
    }

    class Program
    {
        static void Main()
        {
            Calculadora calc = new Calculadora();

            try
            {
                Console.WriteLine($"10 / 2 = {calc.Dividir(10, 2)}");
                Console.WriteLine($"10 / 0 = {calc.Dividir(10, 0)}");
            }
            catch (DivisaoPorZeroException ex)
            {
                Console.WriteLine($"Erro matemático: {ex.Message}");
            }
        }
    }
}
