using BibliotecaValidacoes;

var cpf = new ValidadorCPF();
var email = new ValidadorEmail();
var senha = new ValidadorSenha();

Console.Write("CPF: ");
Console.WriteLine(cpf.Validar(Console.ReadLine()!) ? "CPF valido" : "CPF invalido");

Console.Write("Email: ");
Console.WriteLine(email.Validar(Console.ReadLine()!) ? "Email valido" : "Email invalido");

Console.Write("Senha: ");
Console.WriteLine(senha.Validar(Console.ReadLine()!, 8) ? "Senha valida" : "Senha invalida");
