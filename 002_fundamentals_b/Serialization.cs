using System.Text.Json;

namespace _002_fundamentals_b
{
    public class Serialization(string name, string surname)
    {
        public string Name { get; set; } = name;
        public string Surname { get; set; } = surname;

        public string SerializeToJSON()
        {
            var serialize = new Serialization("Matt", "Damon");
            return JsonSerializer.Serialize(serialize);
        }
    }
}
