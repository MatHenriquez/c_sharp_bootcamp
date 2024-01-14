namespace _001_fundamentals;

internal static class Example
{
    public static int Sum(int a, int b)
    {
        return a + b;
    }

    public static Func<int, int, int> LambdaSum = (a, b) => a + b; // Lambda function. Types: <arg, arg, return>.
}
