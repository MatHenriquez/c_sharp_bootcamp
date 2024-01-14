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


    }
}
