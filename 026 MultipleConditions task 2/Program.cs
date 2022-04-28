using System;

namespace _026_MultipleConditions_task_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите первое число:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите первое число:");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите первое число:");
            int fourthNumber = Convert.ToInt32(Console.ReadLine());

            int maxEvenNumber = default;

            if (firstNumber % 2 == 0)
            {
                maxEvenNumber = firstNumber;
            }

            if ((secondNumber % 2 == 0) && (secondNumber > maxEvenNumber))
            {
                maxEvenNumber = secondNumber;
            }

            if ((thirdNumber % 2 == 0) && (thirdNumber > maxEvenNumber))
            {
                maxEvenNumber = thirdNumber;
            }

            if ((fourthNumber % 2 == 0) && (fourthNumber > maxEvenNumber))
            {
                maxEvenNumber = fourthNumber;
            }

            if (maxEvenNumber != default)
            {
                Console.WriteLine($"Максимальное чётное число: {maxEvenNumber}");
            }
            else
            {
                Console.WriteLine("Not Found");
            }
            Console.ReadKey();
        }
    }
}
