using System.Xml.Linq;

XDocument doc = XDocument.Load("alunos.xml");

foreach (XElement aluno in doc.Root!.Elements("aluno"))
{
    string nome = aluno.Element("nome")!.Value;
    string curso = aluno.Element("curso")!.Value;
    Console.WriteLine("Nome: " + nome);
    Console.WriteLine("Curso: " + curso);
    Console.WriteLine();
}
