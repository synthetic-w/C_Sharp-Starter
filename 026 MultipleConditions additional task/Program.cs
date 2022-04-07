using System;

namespace _026_MultipleConditions_additional_task
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

            switch (inputCommand) {
                case "площадь": {
                        Console.WriteLine($"Площадь равна {firstSide * secondSide}");
                        break;
                    }
                case "периметр": {
                        Console.WriteLine($"Периметр равен {2 * (firstSide + secondSide)}");
                        break;
                    }
                default: {
                        Console.WriteLine("Неверная команда");
                    }
                    break;
            }
            if (firstSide == secondSide) {
                Console.WriteLine("Данный прямоугольник - квадрат");
            }
            Console.ReadKey();
        }
    }
}
