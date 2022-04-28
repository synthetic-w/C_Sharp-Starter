﻿/*
Напишите программу, в которой воспользуйтесь массивом строк из предыдущего
задания.
Создайте цикл, в котором обратитесь к пользователю. Пользователь для первой
итерации цикла должен ввести строковое значение первого по порядку месяца, для
второй итерации – строковое значение второго месяца и так далее до конца массива.
Если пользователь введет неправильно текущее значение месяца – итерация цикла
должна повториться с тем, чтобы пользователь попробовал ввести значение еще
раз. Если пользователь ошибется при вводе значения 5го месяца – цикл должен
прекратить свою работу.
*/

String[] months = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };

Console.WriteLine("Перечислите все месяцы по порядку, начиная с первого в году:");

int index = 0;
string inputSample;
// Проход по месяцам
while (index < months.Length)
{
    inputSample = Console.ReadLine();
    // Проверка соответствия ввода с элементом массива
    if (inputSample == months[index])
    {
        index++;
    }
    // Остановка выполнения программы при хотя бы одном несоответствии при вводе названия пятого месяца
    else if (index == 4 & inputSample != months[index])
    {
        break;
    }
    else
    {
        Console.WriteLine("Введите месяц ещё раз");
    }
}
Console.ReadKey();