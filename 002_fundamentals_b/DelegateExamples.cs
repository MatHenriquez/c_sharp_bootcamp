namespace _002_fundamentals_b
{
    public class DelegateExamples
    {
        public delegate void Greetings(string message);

        public delegate int Adittion(int a, int b);

        private Adittion? adittion;

        Func<int, int> square = x => x * x;

        public void Square(int x)
        {
            Console.WriteLine(square(x));
        }

        public void Sum()
        {
            adittion = (a, b) => a + b;
            Console.WriteLine(adittion(5, 10));
        }

        public void Greeting()
        {
            Greetings welcome = Welcome;
            welcome("Mati");

            Greetings goodbye = Goodbye;
            goodbye("Mati");

            DelegatedMethod(goodbye, "Juli");
        }

        public void DelegatedMethod(Greetings greetings, string name)
        {
            greetings(name);
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
