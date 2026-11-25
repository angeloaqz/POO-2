using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

JObject config = JObject.Parse(File.ReadAllText("config.json"));

Console.WriteLine("Porta atual: " + config["Porta"]);

config["Porta"] = 5433;

File.WriteAllText("config.json", config.ToString(Formatting.Indented));

Console.WriteLine("Nova porta: " + config["Porta"]);
Console.WriteLine(config.ToString(Formatting.Indented));
