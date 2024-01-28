//List<string> pokemons = new List<string>(); Ahora puedo asignar el valor directamente:
List<string> pokemons = ["Pikachu", "Charmander", "Squirtle"];

Task displayAllPokemons = Task.Run(async () => await GetAll(pokemons)); // Recibe un Action como parámetro

static async Task GetAll(List<string> pokemons)
{
    Console.WriteLine("Catching all pokemons");

    await Task.Delay(2000);

    foreach (string pokemon in pokemons)
        Console.WriteLine(pokemon);
}

displayAllPokemons.Wait();

