﻿/*
Напишите программу, в которой создайте массив строковых элементов. В блоке
инициализатора заполните массив названиями месяцев по порядку. Далее создайте
цикл, в котором выведите на экран консоли все содержимое массива строк.
 */
String[] months = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };

int index = 0;
while (index < months.Length)
{
    Console.WriteLine(months[index]);
    index++;
}
Console.ReadKey();