using System.ComponentModel.DataAnnotations;

namespace _001_csharp_v12
{
    internal class Person(int id, string name, string lastName)
    // Primary constructor
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public string LastName { get; set; } = lastName;

        //RegularExpressionAttribute method
        public string getCompleteName()
        {
            return $"{this.Name} {this.LastName}";
        }
    }
}
