namespace _038_MethodOverloading
{
    internal class Program
    {
        /*
        Создать набор перегрузок метода PrintResult:
        ◦ Принимает 3 целочисленные переменные и выводит на экран
        результат их сложения.
        ◦ Принимает 3 целочисленные переменные и выводит на экран
        результат их разности.
        ◦ Принимает 2 целочисленные переменные и выводит первое число
        в степени второго.
        ◦ Принимает 3 целочисленные переменные и вводит на экран сумму
        значений этих переменных представленных в строковом виде
        (пример: «3» + «4» + «5»).
        */

        //1. Сложение 3-х переменных
        private static void PrintResult(int a, int b, int c)
        {
            int result = a + b + c;
            Console.WriteLine($"Результат сложения: {result}");
            return;
        }

        //2. Разность 3-х переменных
        private static void PrintResult(double a, double b, double c)
        {
            double result = a - b - c;
            Console.WriteLine($"Результат вычитания: {result}");
            return;
        }

        //3. Первое число в степени второго
        private static void PrintResult(int a, int b)
        {
            double result = Math.Pow(a, b);
            Console.WriteLine($"Первое число в степени второго: {result}");
            return;
        }

        //4. Сложение 3-х переменных и вывод на экран суммы значений этих переменных представленных в строковом виде
        private static void PrintResult(double a, double b, int c)
        {
            Console.WriteLine($"{a} + {b} + {c}");
            return;
        }

        private static void Main(string[] args)
        {
            PrintResult(1, 2, 3); //1.
            PrintResult(5.0, 4.0, 6.0); //2.
            PrintResult(4, 5); //3.
            PrintResult(7.0, 4.0, 9); //4.
        }
    }
}