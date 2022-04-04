using System;

namespace _003_Variables
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            float gr = 8;
            float ya = 5;
            double polya = 0.5;
            double summ = gr + ya + polya;

            // Количество фруктов в частности и в общем
            Console.WriteLine("Грушек-хуюшек - " + gr);

            Console.WriteLine("Яблок-хуяблок - " + ya);

            Console.WriteLine("Половинка ненужная - " + polya);

            Console.WriteLine("И всего вас, пидарасов - " + summ);

            // Задержка
            Console.ReadKey();
        }
    }
}
