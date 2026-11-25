using Newtonsoft.Json;

List<Produto> produtos = new List<Produto>
{
    new Produto { Id = 1, Nome = "Notebook", Preco = 3500, Estoque = 10, Fornecedor = "Dell", CodigoInterno = "NB-001" },
    new Produto { Id = 2, Nome = "Mouse", Preco = 80, Estoque = 50, Fornecedor = null, CodigoInterno = "MS-002" },
    new Produto { Id = 3, Nome = "Teclado", Preco = 150, Estoque = 30, Fornecedor = "Logitech", CodigoInterno = "TC-003" }
};

JsonSerializerSettings settings = new JsonSerializerSettings
{
    NullValueHandling = NullValueHandling.Ignore
};

string json = JsonConvert.SerializeObject(produtos, Formatting.Indented, settings);
File.WriteAllText("produtos.json", json);

Console.WriteLine("JSON gerado:");
Console.WriteLine(json);
Console.WriteLine();

List<Produto> lidos = JsonConvert.DeserializeObject<List<Produto>>(File.ReadAllText("produtos.json"))!;

Console.WriteLine("Produtos lidos:");
foreach (Produto p in lidos)
{
    Console.WriteLine("Id: " + p.Id);
    Console.WriteLine("Nome: " + p.Nome);
    Console.WriteLine("Preco: " + p.Preco);
    Console.WriteLine("Estoque: " + p.Estoque);
    Console.WriteLine("Fornecedor: " + (p.Fornecedor ?? "nao informado"));
    Console.WriteLine();
}

string jsonInvalido = "[{\"Id\": 9, \"Estoque\": 5}]";

try
{
    JsonConvert.DeserializeObject<List<Produto>>(jsonInvalido);
}
catch (JsonSerializationException ex)
{
    Console.WriteLine("Erro na desserializacao: " + ex.Message);
}
