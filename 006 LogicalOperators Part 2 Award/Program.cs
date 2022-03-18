using System;

namespace _006_LogicalOperators_Part_2_Award
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите выслугу лет:");

            string stringWorkTime = Console.ReadLine();

            int workTime;

            try
            {
                workTime = Convert.ToInt32(stringWorkTime);

                if (workTime < 5)
                {
                    Console.WriteLine("Премия 10%");
                }
                else if (workTime >= 5 && workTime < 10)
                {
                    Console.WriteLine("Премия 15%");
                }
                else if (workTime >= 10 && workTime < 15)
                {
                    Console.WriteLine("Премия 25%");
                }
                else if (workTime >= 15 && workTime < 20)
                {
                    Console.WriteLine("Премия 35%");
                }
                else if (workTime >= 20 && workTime < 25)
                {
                    Console.WriteLine("Премия 45%");
                }
                else if (workTime >= 25)
                {
                    Console.WriteLine("Премия 50%");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("SAM TI HUY");
            }
        }
    }
}
