//List<string> pokemons = new List<string>(); Ahora puedo asignar el valor directamente:
List<string> pokemons = ["Pikachu", "Charmander", "Squirtle"];

//Task displayAllPokemons = Task.Run(async () => await GetAll(pokemons)); // Recibe un Action como parámetro

//static async Task GetAll(List<string> pokemons)
//{
//    Console.WriteLine("Catching all pokemons");

//    await Task.Delay(2000);

//    foreach (string pokemon in pokemons)
//        Console.WriteLine(pokemon);
//}

static async Task<List<string>> GetAllPokemons(List<string> pokemons)
{
    Console.WriteLine("Catching all pokemons");
    await Task.Delay(200);

    foreach (string pokemon in pokemons)
        Console.WriteLine(pokemon);

    return pokemons;
}

//displayAllPokemons.Wait();

//Task displayPokemons = Task.Run(async () => await GetAll(pokemons)); // Con Run no es necesario el .Start()

Task<List<string>> taskDisplayPokemons = Task.Run(() => GetAllPokemons(pokemons)); // Ejecuto directamente

await taskDisplayPokemons.ContinueWith((task) => task.Result);

Console.ReadKey();

