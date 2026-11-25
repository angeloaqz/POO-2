using Newtonsoft.Json;

Livro livro = new Livro
{
    Titulo = "Dom Casmurro",
    Autor = "Machado de Assis",
    Ano = 1899
};

string json = JsonConvert.SerializeObject(livro, Formatting.Indented);

Console.WriteLine(json);
