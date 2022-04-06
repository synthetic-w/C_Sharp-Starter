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

            bool triangleExsistenceCondition = ((sideA + sideB) > sideC) && ((sideA + sideC) > sideB) && ((sideB + sideC) > sideA);

            if (triangleExsistenceCondition) {
                Console.WriteLine("Треугольник с такими сторонами может существовать");

                uint biggestSideSquared = 0, remainSidesSquaredSum = 0;
                {
                    // Нахождение наибольшей стороны (гипотенузы), её квадрата и квадрата оставшихся двух сторон
                    if ((sideA > sideB) && (sideA > sideC)) {
                        biggestSideSquared = sideA * sideA;
                        remainSidesSquaredSum = (sideB * sideB) + (sideC * sideC);
                    }
                    else if ((sideB > sideA) && (sideB > sideC)) {
                        biggestSideSquared = sideB * sideB;
                        remainSidesSquaredSum = (sideA * sideA) + (sideC * sideC);
                    }
                    else if ((sideC > sideA) && (sideC > sideB)) {
                        biggestSideSquared = sideC * sideC;
                        remainSidesSquaredSum = (sideA * sideA) + (sideB * sideB);
                    }
                    else Console.WriteLine("Чёт хуйню какую-то загадал))))))");
                }
                // TODO: исправить баг, когда три одинаковых стороны дают в результате прямоугольный треугольник
                if (biggestSideSquared == remainSidesSquaredSum) {
                    Console.WriteLine("И является прямоугольным - один угол равен 90 градусам");
                }
                else if (biggestSideSquared < remainSidesSquaredSum) {
                    Console.WriteLine("И является остроугольным - все углы меньше 90 градусов");
                }
                else {
                    Console.WriteLine("И является тупоугольным - один угол больше 90 градусов");
                }
            }
            else {
                Console.WriteLine("Треугольник с такими сторонами невозможен");
            }

            Console.ReadKey();
        }
    }
}
