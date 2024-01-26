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

        public static async Task OrderPizza()
        {
            Console.WriteLine("Your ordered a pizza");
            await Task.Delay(7000);
            Console.WriteLine("Your pizza is ready");
        }

        public static async Task TakeShower()
        {
            Console.WriteLine("You go to the bathroom");
            await Task.Delay(3500);
            Console.WriteLine("You are clean");
        }
    }
}
