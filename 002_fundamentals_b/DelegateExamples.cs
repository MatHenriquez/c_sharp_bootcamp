namespace _002_fundamentals_b
{
    public class DelegateExamples
    {
        public delegate void Greetings(string message);

        public void Greeting()
        {
            Greetings welcome = Welcome;
            welcome("Mati");

            Greetings goodbye = Goodbye;
            goodbye("Mati");
        }

        private void Welcome(string name)
        {
            Console.WriteLine($"Welcome, {name}!");
        }

        private void Goodbye(string name)
        {
            Console.WriteLine($"See you later, {name}!");
        }
    }
}
