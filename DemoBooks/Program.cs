using DemoBooks.services;
using DemoBooks.utils;

while (true) // only gets out if find a return statement
{
    Console.Clear();

    int? option = GetOptions();
    OptionEnum optionEnum = (OptionEnum)option;

    if (option == 5)
        return;

    string message = optionEnum switch
    {
        OptionEnum.Add => BookService.AddBook(),
        OptionEnum.Update => BookService.UpdateBook(),
        OptionEnum.Delete => BookService.Delete(),
        OptionEnum.GetAll => BookService.GetAll(),
        OptionEnum.Exit => BookService.Exit(),
        _ => "Invalid option"
    };

    Console.WriteLine("Press Enter to continue...");
    Console.ReadLine();
}

static int? GetOptions()
{
    Console.WriteLine("Welcome to the Bootcamp!");
    Console.WriteLine("1. Create a book");
    Console.WriteLine("2. Edit a book");
    Console.WriteLine("3. Delete a book");
    Console.WriteLine("4. Get all books");
    Console.WriteLine("5. Exit");

    string? option = Console.ReadLine();
    return Convert.ToInt16(option);
}