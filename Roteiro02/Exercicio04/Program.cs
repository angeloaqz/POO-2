using System.Xml.Linq;

string url = "https://www.w3schools.com/xml/simple.xml";

using HttpClient client = new HttpClient();
string response = await client.GetStringAsync(url);
XDocument doc = XDocument.Parse(response);

List<Food> foods = new List<Food>();

foreach (XElement food in doc.Descendants("food"))
{
    foods.Add(new Food
    {
        Name = food.Element("name")!.Value,
        Price = food.Element("price")!.Value
    });
}

foreach (Food food in foods)
{
    Console.WriteLine(food.Name + " - " + food.Price);
}
