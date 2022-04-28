using System;

/* Упражнение 2

Ссылка: https://metanit.com/sharp/practice/1.1.php

Напишите консольную программу, в которую пользователь вводит с клавиатуры число.
Если число одновременно больше 5 и меньше 10, то программа выводит "Число больше 5 и меньше 10".
Иначе программа выводит сообщение "Неизвестное число".
*/

namespace Task_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите число");

            int testNumber = Convert.ToInt32(Console.ReadLine());

            if ((testNumber > 5) && (testNumber < 10))
            {
                Console.WriteLine("Число больше 5 и меньше 10");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }
            Console.ReadKey();
        }
    }
}
