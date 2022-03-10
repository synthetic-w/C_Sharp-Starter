namespace LogicalOperators
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("1. Example below is for type int:"); // 1. Пример для типа int

            int a = 322322, b = 1488228;
            bool isEqual1 = a == b;
            Console.WriteLine($"{a} == {b} = {isEqual1}");

            bool isNotEqual1 = a != b;
            Console.WriteLine($"{a} != {b} = {isNotEqual1}");

            bool isLess1 = a < b;
            Console.WriteLine($"{a} < {b} = {isLess1}");

            bool isLessOrEqual1 = a <= b;
            Console.WriteLine($"{a} <= {b} = {isLessOrEqual1}");

            bool isGreater1 = a > b;
            Console.WriteLine($"{a} > {b} = {isGreater1}");

            bool isGreaterOrEqual1 = a >= b;
            Console.WriteLine($"{a} >= {b} = {isGreaterOrEqual1}");
            Console.WriteLine("______________________________________");

            Console.WriteLine("2. Example below is for type byte:"); // Пример для типа byte

            byte c = 69, d = 228;
            bool isEqual2 = c == d;
            Console.WriteLine($"{c} == {d} = {isEqual2}");

            bool isNotEqual2 = c != d;
            Console.WriteLine($"{c} != {d} = {isNotEqual2}");

            bool isLess2 = c < d;
            Console.WriteLine($"{c} < {d} = {isLess2}");

            bool isLessOrEqual2 = c <= d;
            Console.WriteLine($"{c} <= {d} = {isLessOrEqual2}");

            bool isGreater2 = c > d;
            Console.WriteLine($"{c} > {d} = {isGreater2}");

            bool isGreaterOrEqual2 = c >= d;
            Console.WriteLine($"{c} >= {d} = {isGreaterOrEqual2}");
            Console.WriteLine("______________________________________");

            Console.WriteLine("3. Example below is for type double:"); // Пример для типа double

            double e = 6.66666, f = 4.200069;
            bool isEqual3 = e == f;
            Console.WriteLine($"{e} == {f} = {isEqual3}");

            bool isNotEqual3 = e != f;
            Console.WriteLine($"{e} != {f} = {isNotEqual3}");

            bool isLess3 = e < b;
            Console.WriteLine($"{e} < {f} = {isLess3}");

            bool isLessOrEqual3 = e <= f;
            Console.WriteLine($"{e} <= {f} = {isLessOrEqual3}");

            bool isGreater3 = e > b;
            Console.WriteLine($"{e} > {f} = {isGreater3}");

            bool isGreaterOrEqual3 = e >= f;
            Console.WriteLine($"{e} >= {f} = {isGreaterOrEqual3}");
            Console.WriteLine("______________________________________");

            Console.WriteLine("4. Example below is Za Победу V Украине!"); // Пример для типа char

            char g = 'Z', h = 'V';
            bool isEqual4 = g == h;
            Console.WriteLine($"{g} == {h} = {isEqual4}");

            bool isNotEqual4 = g != h;
            Console.WriteLine($"{g} != {h} = {isNotEqual4}");

            bool isLess4 = g < b;
            Console.WriteLine($"{g} < {h} = {isLess4}");

            bool isLessOrEqual4 = g <= h;
            Console.WriteLine($"{g} <= {h} = {isLessOrEqual4}");

            bool isGreater4 = g > b;
            Console.WriteLine($"{g} > {h} = {isGreater4}");

            bool isGreaterOrEqual4 = g >= h;
            Console.WriteLine($"{g} >= {h} = {isGreaterOrEqual4}");

            Console.ReadKey();
        }
    }
}
