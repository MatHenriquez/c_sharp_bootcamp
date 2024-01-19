﻿using DemoBooks.entitites;

namespace DemoBooks.services
{
    public static class BookService
    {
        public static List<Book> books = new List<Book>();
        public static string AddBook()
        {
            Console.WriteLine("Enter the title");
            string? title = Console.ReadLine();

            Console.WriteLine("Enter the description");
            string? description = Console.ReadLine();

            Console.WriteLine("Enter the author");
            string? author = Console.ReadLine();

            Console.WriteLine("Enter the category");
            string? category = Console.ReadLine();

            Book newBook = new Book
            {
                Id = 1,
                Title = title,
                Author = author,
                Description = description,
                Category = category,
                IsAvailable = true,
            };

            books.Add(newBook);

            string message = $"The book {newBook.Title} has been created successfully";
            Console.WriteLine(message);

            return message;
        }

        public static string UpdateBook()
        {
            Console.WriteLine("Enter thee book ID");
            int? id = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the new title");
            string? title = Console.ReadLine();

            Console.WriteLine("Enter the new description");
            string? description = Console.ReadLine();

            Console.WriteLine("Enter the new author");
            string? author = Console.ReadLine();

            Console.WriteLine("Enter the new cateegory");
            string? category = Console.ReadLine();

            Book? toUpdateBook = books.FirstOrDefault(x => x.Id == id);

            if (toUpdateBook == null)
                return "Book not found";

            else
            {
                toUpdateBook.Title = title;
                toUpdateBook.Author = author;
                toUpdateBook.Description = description;
                toUpdateBook.Category = category;

                string message = $"Book with ID {toUpdateBook.Id} updated successfully";
                return message;
            }
        }
    }
}
