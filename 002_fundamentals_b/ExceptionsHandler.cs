namespace _002_fundamentals_b
{
    public static class ExceptionsHandler
    {
        public static int UnhandledDivision(int x, int y)
        {
            return x / y;
        }

        public static int HandledDivision(int x, int y)
        {
            int result;
            try
            {
                result = x / y;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally { result = 0; }

            return result;
        }

        public static void Run()
        {
            Console.WriteLine("Enter a number:");

            try
            {
                int? input = int.Parse(Console.ReadLine());

                if (input == 10)
                    throw new Exception("Invalid");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"FormatException: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception {e.Message}");
            }
            finally
            {
                Console.WriteLine("End");
            }
        }
    }
}
