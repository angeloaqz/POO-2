using System.Xml.Serialization;

List<Produto> produtos = new List<Produto>
{
    new Produto { Nome = "Mouse", Preco = 59.9 },
    new Produto { Nome = "Teclado", Preco = 129.9 },
    new Produto { Nome = "Monitor", Preco = 899.9 }
};

XmlSerializer serializer = new XmlSerializer(typeof(List<Produto>));

using (StreamWriter writer = new StreamWriter("produtos.xml"))
{
    serializer.Serialize(writer, produtos);
}

Console.WriteLine(File.ReadAllText("produtos.xml"));
