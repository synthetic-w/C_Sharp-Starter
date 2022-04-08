/*See https://aka.ms/new-console-template for more information

Упражнение 6

Ссылка https://metanit.com/sharp/practice/1.1.php

Напишите консольную программу, которая выводит пользователю сообщение "Введите номер операции:
1.Сложение 2.Вычитание 3.Умножение". Рядом с названием каждой операции указан ее номер, например, операция вычитания имеет номер 2.
Пусть пользователь вводит в программу номер операции, и в зависимости от номера операции программа выводит ему название операции.

Для определения операции по введенному номеру используйте конструкцию switch...case.

Если введенное пользователем число не соответствует никакой операции (например, число 120), то выведите пользователю сообщение о том, что операция неопределена.

Упражнение 7

Измените предыдущую программу. Пусть пользователь кроме номера операции вводит два числа,
и в зависимости от номера операции с введенными числами выполняются определенные действия (например, при вводе числа 3 числа умножаются).
Результа операции выводиться на консоль.
*/

Console.WriteLine("Введите первое число");

int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение 4.Деление");

int operationType = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");

int secondNumber = Convert.ToInt32(Console.ReadLine());

switch (operationType)
{
    case 1:
        Console.WriteLine($"Сложение: {firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
        break;

    case 2:
        Console.WriteLine($"Вычитание: {firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
        break;

    case 3:
        Console.WriteLine($"Умножение: {firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
        break;

    case 4:
        if (secondNumber != 0) {
            Console.WriteLine($"Деление: {firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
        }
        else {
            Console.WriteLine("На ноль делить нельзя!");
        }
        break;

    default:
        Console.WriteLine("Операция не определена");
        break;
}

Console.ReadKey();
