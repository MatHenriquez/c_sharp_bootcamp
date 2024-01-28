using _002_fundamentals_b;

////Console.WriteLine(ExceptionsHandler.UnhandledDivision(1, 0)); // Error
//Console.WriteLine(ExceptionsHandler.HandledDivision(1, 0));

//ExceptionsHandler.Run();

//Console.Clear();
//Console.WriteLine("Press a key to take a nap");
//Console.ReadLine();

//AsyncExample.TakeNap();

//Console.Clear();
//Console.WriteLine("Press a key to order pizza");
//Console.ReadLine();

////AsyncExample.OrderPizza(); // With await this will be similar to sinchronic
////AsyncExample.TakeShower();

//Task orderPizza = AsyncExample.OrderPizza();
//Task takeShower = AsyncExample.TakeShower();
//await Task.WhenAll(orderPizza, takeShower);

//Console.ReadKey();

//var multiplicar = (int a, int b) => a*b;
//Console.WriteLine((multiplicar(4, 7)));

//var isAdult = (int age) => age >= 18;
//Console.WriteLine(isAdult(21));

//DelegateExamples delegateExamples = new DelegateExamples();
//delegateExamples.Greeting();

DelegateExamples delegateExamples = new DelegateExamples();
delegateExamples.Sum();