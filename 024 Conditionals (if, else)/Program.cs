using System;

namespace _022_Conditionals__if__else_
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("В зависимости от введённого числа, оно увеличится или умножится на 10:");
            int inputNumber = Convert.ToInt32(Console.ReadLine());

            int outputNumber;
            {
                if (inputNumber > 3) {
                    outputNumber = inputNumber + 10;
                }
                else {
                    outputNumber = inputNumber * 10;
                }
            }
            Console.WriteLine($"Результат: {outputNumber}");

            Console.ReadKey();
        }
    }
}
