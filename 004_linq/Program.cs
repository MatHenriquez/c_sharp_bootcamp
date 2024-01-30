﻿using LINQDemos;

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

//// Obtengo los nombres de los estudiantes
//IEnumerable<string> names = DBContext.Students.Select(s => s.FirstName);

//// Obtengo los nombres y appellidos de los estudiantes
//IEnumerable<string> namesAndLastNames = DBContext.Students.Select(s => $"{s.FirstName} {s.LastName}");

//// Obtengo los nombre de las univerdades de USA
//IEnumerable<string> universities = DBContext.Universities.Where(u => u.Country == "USA").Select(u => u.Name);

// Obtengo los nombre de las univerdades ordenadas por nombre
//IEnumerable<string> universities = DBContext.Universities.OrderBy(u => u.Name).Select(u => u.Name);

// Obtengo los nombre de las univerdades ordenadas por nombre descendente
//IEnumerable<string> universities = DBContext.Universities.OrderByDescending(u => u.Name).Select(u => u.Name);

// Agrrupo universidades por país
//var universities = DBContext.Universities.GroupBy(u => u.Country);

//foreach (var group in universities)
//{
//    Console.WriteLine($"Universities in {group.Key}: {group.Count()}");
//    foreach (var university in group)
//    {
//        Console.WriteLine($"\t{university.Name}");
//    }
//}

// Obtengo cantidad de universidades en Canadá
//int universitiesInCanada = DBContext.Universities.Count(u => u.Country == "Canada");
//Console.WriteLine($"Universities in Canada: {universitiesInCanada}");

// Obtengo la cantidad de países en los que hay universidades
//int countriesWithUniversities = DBContext.Universities.Select(u => u.Country).Distinct().Count();
//Console.WriteLine($"Countries with universities: {countriesWithUniversities}");

// Obtengo nombre, apellido y país de los estudiantes
//var values = DBContext.Students.Join(DBContext.Universities, s => s.UniversityId, u => u.Id, (s, u) => new { s.FirstName, s.LastName, u.Name });

var values = from n in DBContext.Students
             join u in DBContext.Universities on n.UniversityId equals u.Id
             select new { n.FirstName, n.LastName, u.Name };

foreach (var value in values)
{
    Console.WriteLine($"{value.FirstName} {value.LastName} - {value.Name}");
}