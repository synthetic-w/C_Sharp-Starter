using System;

namespace _007BitOperations
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int x = 5, y = 10, z = 15;

            Console.WriteLine("Дано: x = 5, y = 10, z = 15");
            Console.WriteLine("________________________________");
            Console.WriteLine("Вычислите:");
            Console.WriteLine("x += y >> x++ * z;");
            Console.WriteLine("z = ++x & y * 5;");
            Console.WriteLine("y /= x + 5 | z;");
            Console.WriteLine("z = x++ & y * 5");
            Console.WriteLine("x = y << x++ ^ z;");
            Console.WriteLine("________________________________");

            x += y >> x++ * z;
            z = ++x & y * 5;
            y /= x + 5 | z;
            z = x++ & y * 5;
            x = y << x++ ^ z;

            Console.WriteLine($"Результат: x = {x}, y = {y}, z = {z} ");

            Console.ReadKey();
        }
    }
}
