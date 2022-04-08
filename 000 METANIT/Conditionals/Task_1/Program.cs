using System;

/*Упражнение 1

Ссылка: https://metanit.com/sharp/practice/1.1.php

Напишите консольную программу, в которую пользователь вводит с клавиатуры два числа.
А программа сранивает два введенных числа и выводит на консоль результат сравнения   ( Ctrl + k + c  - быстро закомментировать выделенную область)
(два числа равны, первое число больше второго или первое число меньше второго).      ( Ctrl + k + u  - быстро раскомментить выделенную область)
*/

namespace Task_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа для сравнения:\nПервое число:");

            int numberOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Второе число:");

            int numberTwo = Convert.ToInt32(Console.ReadLine());

            if (numberOne > numberTwo) {
                Console.WriteLine($"Первое\n{new String(' ', 4)}число\n{new String(' ', 8)}больше\n{new String(' ', 12)}второго");
            }
            else if (numberTwo > numberOne) {
                Console.WriteLine($"Второе\n{new String(' ', 4)}число\n{new String(' ', 8)}больше\n{new String(' ', 12)}первого");
            }
            else {
                Console.WriteLine($"Оба\n{new String(' ', 4)}числа\n{new String(' ', 8)}равны");
            }

            Console.ReadKey();
        }
    }
}
