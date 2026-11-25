using BibliotecaConversao;

var conversor = new Conversor();

Console.WriteLine("25 C = " + conversor.CelsiusParaFahrenheit(25) + " F");
Console.WriteLine("1500 m = " + conversor.MetrosParaQuilometros(1500) + " km");

Console.Write("Digite o valor: ");
double valor = double.Parse(Console.ReadLine()!);

Console.Write("Digite a taxa de cambio: ");
double taxa = double.Parse(Console.ReadLine()!);

Console.WriteLine("Valor convertido: " + conversor.ConverterMoeda(valor, taxa));
