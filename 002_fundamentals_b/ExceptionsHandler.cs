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
            try
            {
                return x / y;
            }
            catch
            {
                return -1;
            }
        }
    }
}
