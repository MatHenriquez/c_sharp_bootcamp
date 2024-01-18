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
        public string GetCompleteName()
        {
            return $"{this.Name} {this.LastName}";
        }

        public string LocalGetAllInfo()
        {
            Func<int, string, string, string> getAllInfo = (int id, string name, string lastName) => $"Person {id}, full name: {name} {lastName}";
            return getAllInfo(this.Id, this.Name, this.LastName);
        }

        public string GetId()
        {
            return getIdAsString();

            string getIdAsString() // Local function
            {
                return this.Id.ToString();
            }
        }

        public string GetGreetings(string firstName)
        {
            string Message(string firstName)
            {
                return $"Hello, {firstName}";
            }

            return Message(firstName);
        }
    }
}
