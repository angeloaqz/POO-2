namespace BibliotecaFinanceira;

public class CalculadoraJuros
{
    public double JurosSimples(double capital, double taxa, double tempo)
    {
        return CalculoInterno(capital, taxa, tempo);
    }

    internal double CalculoInterno(double capital, double taxa, double tempo)
    {
        return capital * (taxa / 100) * tempo;
    }
}
