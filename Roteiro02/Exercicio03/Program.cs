using System.Xml.Linq;

XDocument doc = XDocument.Load("estoque.xml");

XElement? item = doc.Root!.Elements("item")
    .FirstOrDefault(i => i.Element("nome")!.Value == "Mouse");

if (item != null)
{
    item.Element("quantidade")!.Value = "10";
    doc.Save("estoque.xml");
}

Console.WriteLine(File.ReadAllText("estoque.xml"));
