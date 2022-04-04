using System;

namespace MyProgram
{
    /* Программа Ah shit, here we go again
       Выводит в консоли "Ah shit, here we go again"
    */

    internal class Program // Класс не обязательно должен называться "Program"
    {
        private static void Main(string[] args) // Этот метод обязательно должен называться "Main"
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Ah shit, here we go again");

            Console.ForegroundColor++;
            Console.BackgroundColor++;
            Console.WriteLine("Bye, officer");

            Console.ForegroundColor++;
            Console.BackgroundColor++;
            Console.WriteLine("I'll be watching you, Carl");

            Console.ForegroundColor++;
            Console.BackgroundColor++;
            Console.WriteLine("Yeah, Carl, we'll be watching you");

            Console.ReadKey();
        }
    }
}
