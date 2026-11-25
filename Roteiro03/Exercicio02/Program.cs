using Newtonsoft.Json;

string json = File.ReadAllText("aluno.json");
Aluno aluno = JsonConvert.DeserializeObject<Aluno>(json)!;

Console.WriteLine("Nome: " + aluno.Nome);
Console.WriteLine("Idade: " + aluno.Idade);
Console.WriteLine("Curso: " + aluno.Curso);
