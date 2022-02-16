using System;

namespace NumericOperations
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int i = 5;
            double d = 0.228;
            byte b = 3;
            float f = 1;
            long l = 100;
            short s = 9;

            sbyte SB = (sbyte)(i + d + b + f + l + s);

            Console.WriteLine(SB);

            Console.ReadKey();
        }
    }
}
