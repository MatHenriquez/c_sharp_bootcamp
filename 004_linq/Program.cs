void SayHello()
{
    Console.WriteLine("Hello");
}

Action sayHello = () => Console.WriteLine("Hello"); // Action cuando no devuelve un valor

SayHello();
sayHello();
