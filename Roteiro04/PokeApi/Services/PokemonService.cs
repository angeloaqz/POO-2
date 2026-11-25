using Newtonsoft.Json.Linq;
using PokeApi.Models;

namespace PokeApi.Services;

public class PokemonService
{
    private static readonly HttpClient client = new HttpClient();

    public async Task<Pokemon?> BuscarPokemon(string nome)
    {
        string url = "https://pokeapi.co/api/v2/pokemon/" + nome.Trim().ToLower();
        HttpResponseMessage resposta = await client.GetAsync(url);

        if (!resposta.IsSuccessStatusCode)
        {
            return null;
        }

        JObject json = JObject.Parse(await resposta.Content.ReadAsStringAsync());

        Pokemon pokemon = new Pokemon
        {
            Id = (int)json["id"]!,
            Name = (string)json["name"]!,
            Height = (int)json["height"]!,
            Weight = (int)json["weight"]!,
            BaseExperience = (int?)json["base_experience"] ?? 0,
            Types = json["types"]!.Select(t => (string)t["type"]!["name"]!).ToList()
        };

        return pokemon;
    }

    public async Task<Pokemon?> BuscarPokemonAleatorio()
    {
        int id = Random.Shared.Next(1, 1026);
        return await BuscarPokemon(id.ToString());
    }
}
