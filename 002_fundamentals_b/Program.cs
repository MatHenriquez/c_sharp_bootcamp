﻿using _002_fundamentals_b;

//Console.WriteLine(ExceptionsHandler.UnhandledDivision(1, 0)); // Error
Console.WriteLine(ExceptionsHandler.HandledDivision(1, 0));

ExceptionsHandler.Run();

Console.Clear();
Console.WriteLine("Press a key to take a nap");
Console.ReadLine();

AsyncExample.TakeNap();

Console.Clear();
Console.WriteLine("Press a key to order pizza");
Console.ReadLine();

AsyncExample.OrderPizza();
AsyncExample.TakeShower();

Console.ReadKey();