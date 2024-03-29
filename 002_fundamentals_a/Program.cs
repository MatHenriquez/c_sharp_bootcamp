﻿public class DataType
{
    // Integers
    sbyte sShortNumber = 127;                   // 8 bits, signed (- or +)
    byte byteNumber = 255;                      // 8 bits, unsigned (0 or +)
    short shortNumber = 32767;                  // 16 bits, signed
    ushort uShortNumber = 65535;                // 16 bits, unsigned
    int intNumber = 2147483647;                 // 32 bits, signed
    uint uintNumber = 2147483648;               // 32 bits, unsigned
    long longNumber = 922564415646;             // 64 bits, signed
    ulong ulongNumber = 9225644156465555555;    // 64 bits, unsigned

    // Rational numbers
    float floatNumber = 15.05f;                 // 32 bits
    double doubleNumber = 10.3232;              // 64 bits
    decimal decimalNumber = 100.0254m;          // 128 bits

    // Text
    char characters = 'a';                      // 16 bits, single quotes
    string chain = "Hello";                     // Double quotes

    // Booleans and objects
    bool isBool = true;                         // Possible values: true or false
    object objectTest = new object();           // Any type
    dynamic dynamicTest = 10;                   // Any type, defined in execution time
    //var lastName = "Smith";                   // Any type, defined in compilation time

    // Constants
    const int IVA = 21;                         // Fixed value

    public void OutParametersMethod(out int firstNumber, out int secondNumber)
    {
        firstNumber = 0;
        secondNumber = 1;
    }

    //I can do:
    //int myFirstNumber;
    //int mySecondNumber;
    //OutParametersMethod(out myFirstNumber, out mySecondNumber);

    // Generics
    public void GenericMethod<T>(T myParameter) where T : class
    {
        Console.WriteLine(myParameter);
    }

    // Sobrecarga
    public int GenericMethod<T>(T myParameter, int myNumber) where T : class
    {
        Console.WriteLine(myParameter);
        return myNumber;
    }
}

public class IntegerType : DataType
{
    // This class extends DataType
}

public interface IAnimal
{
    void Eat();
    void Walk();
    void Sleep();
}

public class Animal : IAnimal
{
    public void Eat()
    {
        Console.WriteLine("Eating");
    }
    public void Walk()
    {
        Console.WriteLine("Walking");
    }

    public void Sleep()
    {
        Console.WriteLine("Sleeping");
    }
}

public abstract class Person
{
    public string firstName;

    public abstract void Work();
}
public class Matt : Person
{
    public string firstName;

    public override void Work()
    {
        throw new NotImplementedException();
    }
}

public class Employee : Person
{
    public Employee(string firstName) // Constructor
    {
        FirstName = firstName;
    }

    public string FirstName;

    public override void Work()
    {
        throw new NotImplementedException();
    }
}