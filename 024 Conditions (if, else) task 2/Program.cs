using System;

namespace _022_Conditions__if__else__task_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine($"Введите поочередно три стороны треугольника - A, B и C");

            Console.WriteLine("Сторона A:");
            uint sideA = (uint)Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сторона B:");
            uint sideB = (uint)Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сторона C:");
            uint sideC = (uint)Convert.ToInt32(Console.ReadLine());

            // Условие существования треугольника
            bool triangleExsistenceCondition = ((sideA + sideB) > sideC) && ((sideA + sideC) > sideB) && ((sideB + sideC) > sideA);

            if (triangleExsistenceCondition) {
                Console.WriteLine("Треугольник с такими сторонами может существовать");

                // Проверка теоремы Пифагора
                if ((Math.Pow(sideA, 2) + Math.Pow(sideB, 2) == Math.Pow(sideC, 2))
                    || (Math.Pow(sideB, 2) + Math.Pow(sideC, 2) == Math.Pow(sideA, 2))
                    || (Math.Pow(sideA, 2) + Math.Pow(sideC, 2) == Math.Pow(sideB, 2))) {
                    Console.WriteLine("И является прямоугольным - один угол равен 90 градусам");
                }
                else if ((sideA == sideB) && (sideA == sideC)) {
                    Console.WriteLine(("И является равносторонним, т.к. все его стороны равны"));
                }
                else if ((sideA == sideB) || (sideA == sideC) || (sideB == sideC)) {
                    Console.WriteLine("И является равнобедренным, т.к. две его стороны равны");
                }
            }
            else {
                Console.WriteLine("Треугольник с такими сторонами невозможен");
            }

            Console.ReadKey();
        }
    }
}
