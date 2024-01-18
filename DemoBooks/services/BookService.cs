using DemoBooks.entitites;

namespace DemoBooks.services
{
    public static class BookService
    {
        public static List<Book> books = new List<Book>();
        public static string AddBook()
        {
            Console.WriteLine("Enter the title");
            string? title = Console.ReadLine();

            Console.WriteLine("Enter the author");
            string? author = Console.ReadLine();

            Console.WriteLine("Enter the category");
            string? category = Console.ReadLine();

            Book newBook = new Book 
            {
                Id = 1,
                Title = title,
                Author = author,
                Category = category,
                IsAvailable = true,
            };

            books.Add(newBook);

            return $"The book {newBook.Title} has been created successfully";
        }
    }
}
