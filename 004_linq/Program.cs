using LINQDemos;

//void SayHello()
//{
//    Console.WriteLine("Hello");
//}

//Action sayHello = () => Console.WriteLine("Hello"); // Action cuando no devuelve un valor

//SayHello();
//sayHello();

//double GetPi()
//{
//    return 3.1416;
//}

//Func<double> getPi = () => 3.1416; // Func cuando devuelve un valor

//Console.WriteLine(GetPi());
//Console.WriteLine(getPi());

// Obtengo los nombres de los estudiantes
IEnumerable<string> names = DBContext.Students.Select(s => s.FirstName);

foreach (string name in names)
{
    Console.WriteLine(name);
}