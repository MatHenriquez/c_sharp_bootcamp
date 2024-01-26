namespace _002_fundamentals_b
{
    public static class AsyncExample
    {
        public static void TakeNap()
        {
            Console.WriteLine("Going to bed");
            Thread.Sleep(5000);
            Console.WriteLine("I'm up");
        }
    }
}
