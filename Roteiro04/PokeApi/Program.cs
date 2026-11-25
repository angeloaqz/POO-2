using PokeApi.Models;
using PokeApi.Services;

PokemonService service = new PokemonService();

while (true)
{
    Console.WriteLine("1 - Buscar pokemon pelo nome");
    Console.WriteLine("2 - Buscar pokemon aleatorio");
    Console.WriteLine("0 - Sair");
    Console.Write("Opcao: ");
    string opcao = Console.ReadLine()!;

    if (opcao == "0")
    {
        break;
    }

    Pokemon? pokemon = null;

    if (opcao == "1")
    {
        Console.Write("Digite o nome do pokemon: ");
        string nome = Console.ReadLine()!;
        pokemon = await service.BuscarPokemon(nome);
    }
    else if (opcao == "2")
    {
        pokemon = await service.BuscarPokemonAleatorio();
    }
    else
    {
        Console.WriteLine("Opcao invalida");
        Console.WriteLine();
        continue;
    }

    if (pokemon == null)
    {
        Console.WriteLine("Pokemon nao encontrado");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Pokemon encontrado!");
        Console.WriteLine("ID: " + pokemon.Id);
        Console.WriteLine("Nome: " + pokemon.Name);
        Console.WriteLine("Altura: " + pokemon.Height);
        Console.WriteLine("Peso: " + pokemon.Weight);
        Console.WriteLine("Base experience: " + pokemon.BaseExperience);
        Console.WriteLine("Tipos: " + string.Join(", ", pokemon.Types));
    }

    Console.WriteLine();
}
