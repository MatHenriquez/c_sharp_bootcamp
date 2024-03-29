﻿using _001_csharp_v12;

namespace Lambdas;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
        Console.WriteLine(LambdasCases.RegularLambdaSum(1, 2));
        Console.WriteLine(LambdasCases.DefaultValuesSum());
        Console.WriteLine(LambdasCases.VarLambdaSum(1, 2, 3));
        Console.WriteLine(new Person(0, "Matías", "Henríquez").GetCompleteName());
        Console.WriteLine(new Person(0, "Matías", "Henríquez").LocalGetAllInfo());
        Console.WriteLine(new Person(0, "Matías", "Henríquez").GetId());

        Person me = new Person(0, "Matías", "Henríquez");
        Console.WriteLine(me.GetGreetings("Matías"));
    }
}