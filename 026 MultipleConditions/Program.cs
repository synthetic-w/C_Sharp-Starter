﻿using System;

namespace _026_MultipleConditions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите значение первой стороны прямоугольника:");
            double firstSide = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение второй стороны прямоугольника:");
            double secondSide = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Для нахождения площади введите \"площадь\" \n" +
                "Для нахождения периметра введите \"периметр\" ");
            string inputCommand = Console.ReadLine().ToLower(); // ToLower - конвертирует все символы в нижний регистр

            if (inputCommand == "площадь")
            {
                Console.WriteLine($"Площадь равна {firstSide * secondSide}");
            }
            else if (inputCommand == "периметр")
            {
                Console.WriteLine($"Периметр равен {(firstSide + secondSide) * 2}");
            }
            else
            {
                Console.WriteLine("Неверная команда");
            }

            if (firstSide == secondSide)
            {
                Console.WriteLine("Данный прямоугольник - квадрат");
            }
            Console.ReadKey();
        }
    }
}
