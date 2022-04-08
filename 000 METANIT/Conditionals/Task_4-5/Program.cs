using System;

/* Упражнение 4

Ссылка: https://metanit.com/sharp/practice/1.1.php

В банке в зависимости от суммы вклада начисляемый процент по вкладу может отличаться.
Напишите консольную программу, в которую пользователь вводит сумму вклада. Если сумма вклада меньше 100, то начисляется 5%.
Если сумма вклада от 100 до 200, то начисляется 7%. Если сумма вклада больше 200, то начисляется 10%.
В конце программа должна выводить сумму вклада с начисленными процентами.

Для получения вводимого с клавиатуры числа используйте выражение Convert.ToDouble(Console.ReadLine())

Упражнение 5
Изменим предыдущую задачу. Допустим, банк периодически начисляет по всем вкладам кроме процентов бонусы.
И, допустим, сейчас банк решил доначислить по всем вкладам 15 единиц вне зависимости от их суммы.
Измените программу таким образом, чтобы к финальной сумме дочислялись бонусы.
*/

namespace Task_4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // While стоит для зацикливания для проверки
            while (true) {
                Console.WriteLine("Введите сумму вклада:");

                double depositValue = Convert.ToDouble(Console.ReadLine());

                {
                    if (depositValue < 100) {
                        depositValue += depositValue * 0.05;
                    }
                    else if (depositValue >= 100 && depositValue < 200) {
                        depositValue += depositValue * 0.07;
                    }
                    else if (depositValue > 200) {
                        depositValue += depositValue * 0.1;
                    }
                }

                Console.WriteLine($"Итоговая сумма вклада с процентами и с бонусом в 15 единиц: {depositValue + 15}");

                Console.ReadKey();
            }
        }
    }
}
