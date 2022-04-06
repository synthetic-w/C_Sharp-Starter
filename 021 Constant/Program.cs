using System;

namespace _021_Constant
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите значение числа Пи: ");

            // 1. Сравнение значения константы PI с введённым значением
            const double PI = 3.141593;
            bool isConstBigger;
            {
                double inputValue = Convert.ToDouble(Console.ReadLine());
                isConstBigger = PI == inputValue;
            }

            // 2. Сравнение значения константы MY_CONST с результирующим значением блока 1
            const bool MY_CONST = true;
            bool isBoolTrue;
            {
                isBoolTrue = MY_CONST == isConstBigger;
                Console.WriteLine($"Результат финального сравнения {isBoolTrue}");
            }

            Console.ReadKey();
        }
    }
}
