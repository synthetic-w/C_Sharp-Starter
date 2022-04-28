/*
Напишите программу, в которой, используя конструкции цикла со счетчиком:
1. Выведите на экран консоли все числа от 0 до 100;
2. Выведите на экран числа от 1001 до 2500 с шагом – 3;
3. Выведите числа от 100 до 0 с шагом – 4;
4. Выведите числа от 1 до 5 с шагом 0,2.
*/

// 1. Вывод на экран всех чисел от 0 до 100
Console.WriteLine("1. Нажмите любую клавишу для вывода всех целых чисел от 0 до 100");
Console.ReadKey();

for (int index = 0; index <= 100; index++)
{
    Console.WriteLine(index);
}
Console.ReadKey();

// 2. Вывод на экран чисел от 1001 до 2500 с шагом 3
Console.WriteLine("2. Нажмите любую клавишу для вывода всех целых чисел от 1001 до 2500 с шагом 3");
Console.ReadKey();

for (int index = 1001; index <= 2500; index += 3)
{
    Console.WriteLine(index);
}

Console.ReadKey();

// 3. Вывод на экран чисел от 100 до 0 с шагом 4
Console.WriteLine("3. Нажмите любую клавишу для вывода всех целых чисел от 100 до 0 с шагом 4");
Console.ReadKey();

for (int index = 100; index >= 0; index -= 4)
{
    Console.WriteLine(index);
}

Console.ReadKey();

// 4. Вывод на экран чисел от 1 до 5 с шагом 0,2
Console.WriteLine("3. Нажмите любую клавишу для вывода всех чисел от 1 до 5 с шагом 0,2");
Console.ReadKey();

for (double index = 1; index <= 5; index += 0.2)
{
    Console.WriteLine(Math.Round(index, 1));
}

Console.ReadKey();