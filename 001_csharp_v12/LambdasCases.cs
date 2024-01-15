namespace _001_csharp_v12
{
    internal class LambdasCases
    {
        // Regular Lambda function method.
        public static int RegularLambdaSum(int x, int y)
        {
            Func<int, int, int> LambdaSum = (int x, int y) => x + y;
            return LambdaSum(x, y);
        }

        // Sum with default values.
        public static int DefaultValuesSum(int x = 0, int y = 0)
        {
            Func<int, int, int> LambdaSum = (int x, int y) => x + y;
            return LambdaSum(x, y);
        }

        // Lambda method with and undefined number of arguments.
        public static int VarLambdaSum(int x, int y, int z)
        {
            var sum = (params int[] args) =>
            {
                int total = 0;

                foreach (int x in args)
                    total += x;

                return total;
            };

            return sum(x, y,z);
        }
    }
}
