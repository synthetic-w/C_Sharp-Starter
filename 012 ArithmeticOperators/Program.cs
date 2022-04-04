using System;

namespace AriеhmeticOperators
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int x = 10, y = 12, z = 3;
            Console.WriteLine($"Даны x = {x}, y = {y}, z = {z}");
            Console.WriteLine("_________________________________");

            Console.WriteLine("1. x += y - x++ * z"); // 1 блок вычислений
            Console.WriteLine("Результат вычислений:");
            x += y - x++ * z;

            Console.WriteLine($"x = {x}");
            Console.WriteLine("_________________________________");

            Console.WriteLine("2. z = --x - y * 5"); // 2 блок вычислений
            Console.WriteLine("Результат вычислений:");
            z = --x - y * 5;

            Console.WriteLine($"z = {z}");
            Console.WriteLine("_________________________________");

            Console.WriteLine("3. y /= x + 5 % z"); // 3 блок вычислений
            Console.WriteLine("Результат вычислений:");
            y /= x + 5 % z;

            Console.WriteLine($"y = {y}");
            Console.WriteLine("_________________________________");

            Console.WriteLine("4. z = x++ + y * 5"); // 4 блок вычислений
            Console.WriteLine("Результат вычислений:");
            z = x++ + y * 5;

            Console.WriteLine($"z = {z}");
            Console.WriteLine("_________________________________");

            Console.WriteLine("4. x = y - x++ * z"); // 5 блок вычислений
            Console.WriteLine("Результат вычислений:");
            x = y - x++ * z;

            Console.WriteLine($"x = {x}");
            Console.WriteLine("_________________________________");

            Console.ReadKey();
        }
    }
}
