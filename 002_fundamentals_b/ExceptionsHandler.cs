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
    }
}
