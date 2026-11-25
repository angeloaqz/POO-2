using System.Net.Mail;

namespace BibliotecaValidacoes;

public class ValidadorEmail
{
    public bool Validar(string email)
    {
        try
        {
            var endereco = new MailAddress(email);
            return endereco.Address == email;
        }
        catch
        {
            return false;
        }
    }
}
