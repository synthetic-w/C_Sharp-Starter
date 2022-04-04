using System;

namespace Scope
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите значение переменной а:");
            int a = Convert.ToInt32(Console.ReadLine());

            {
                a = a++ * 2 + 1488 / 228; // Локальная область 1 с преобразованием
            }

            {
                Console.WriteLine($"Значение переменной а после преобразования: {a}"); // Локальная область 2 с выводом
            }

            Console.ReadKey();
        }
    }
}
