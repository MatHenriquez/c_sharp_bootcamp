void SayHello()
{
    Console.WriteLine("Hello");
}

Action sayHello = () => Console.WriteLine("Hello"); // Action cuando no devuelve un valor

SayHello();
sayHello();

double GetPi()
{
    return 3.1416;
}

Func<double> getPi = () => 3.1416; // Func cuando devuelve un valor

Console.WriteLine(GetPi());
Console.WriteLine(getPi());