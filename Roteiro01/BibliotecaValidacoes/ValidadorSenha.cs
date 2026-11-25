namespace BibliotecaValidacoes;

public class ValidadorSenha
{
    public bool Validar(string senha, int tamanhoMinimo)
    {
        return senha.Length >= tamanhoMinimo
            && senha.Any(char.IsUpper)
            && senha.Any(char.IsDigit);
    }
}
