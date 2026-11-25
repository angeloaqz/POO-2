using Newtonsoft.Json;

List<Carro> carros = new List<Carro>
{
    new Carro { Marca = "Fiat", Modelo = "Uno", Ano = 2015 },
    new Carro { Marca = "Volkswagen", Modelo = "Gol", Ano = 2018 },
    new Carro { Marca = "Chevrolet", Modelo = "Onix", Ano = 2021 }
};

string json = JsonConvert.SerializeObject(carros, Formatting.Indented);
File.WriteAllText("carros.json", json);

List<Carro> lidos = JsonConvert.DeserializeObject<List<Carro>>(File.ReadAllText("carros.json"))!;

foreach (Carro carro in lidos)
{
    Console.WriteLine(carro.Marca + " " + carro.Modelo + " - " + carro.Ano);
}
