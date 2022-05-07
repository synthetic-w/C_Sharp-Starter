using System.Numerics;

namespace _039_Recursion
{
    internal class Program
    {
        /*
        Создайте метод, в теле которого происходит вычисление факториала числа
        рекурсивно. Прошагайте и выведите на экран результат вычисления факториала 5.

        Создайте другой метод, в котором вычисление факториала числа реализуйте с
        помощью циклов

        Вычислите значения факториалов для 5, 6, 10, 100
         */

        // Метод вычисления факториала рекурсивно
        private static BigInteger RecursiveFactorial(BigInteger number)
        {
            if (number == 1) return 1;
            return number * RecursiveFactorial(number - 1);
        }

        // Метод вычисления факториала циклически
        private static BigInteger CyclicFactorial(BigInteger number)
        {
            BigInteger intermediateResult = 1;

            for (BigInteger factor = 1; factor <= number; factor++)
            {
                intermediateResult = intermediateResult * factor;
            }
            return intermediateResult;
        }

        private static void Main()
        {
            //Вычисление факториала рекурсивно
            Console.WriteLine($"Введите число, факториал которого требуется найти рекурсивно:");
            BigInteger number1 = Convert.ToInt32(Console.ReadLine());

            BigInteger factorial1 = RecursiveFactorial(number1);
            Console.WriteLine($"{number1}! = {factorial1}");

            //Вычисление факториала циклически
            Console.WriteLine($"Введите число, факториал которого требуется найти циклически:");
            BigInteger number2 = Convert.ToInt32(Console.ReadLine());

            BigInteger factorial2 = CyclicFactorial(number2);
            Console.WriteLine($"{number1}! = {factorial1}");
        }
    }
}