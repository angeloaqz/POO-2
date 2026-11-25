namespace BibliotecaValidacoes;

public class ValidadorCPF
{
    public bool Validar(string cpf)
    {
        string numeros = new string(cpf.Where(char.IsDigit).ToArray());

        if (numeros.Length != 11 || numeros.Distinct().Count() == 1)
        {
            return false;
        }

        for (int t = 9; t <= 10; t++)
        {
            int soma = 0;
            for (int i = 0; i < t; i++)
            {
                soma += (numeros[i] - '0') * (t + 1 - i);
            }

            int digito = (soma * 10) % 11;
            if (digito == 10)
            {
                digito = 0;
            }

            if (digito != numeros[t] - '0')
            {
                return false;
            }
        }

        return true;
    }
}
