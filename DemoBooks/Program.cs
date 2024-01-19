using DemoBooks.services;
using DemoBooks.utils;

while (true) // only gets out if find a return statement
{
    int? option = GetOptions();
    OptionEnum optionEnum = (OptionEnum)option;

    if (optionEnum == OptionEnum.Exit)
        return;

    string meessage = optionEnum switch
    {
        OptionEnum.Add => BookService.AddBook(),
        OptionEnum.Update => BookService.UpdateBook(),
        OptionEnum.Delete => "Delete book",
        OptionEnum.GetAll => "Get all books",
        OptionEnum.Exit => "Salir",
        _ => "Invalid option"
    };
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