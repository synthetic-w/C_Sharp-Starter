/* See https://aka.ms/new-console-template for more information

Задание 3

Напишите программу, в которой:

1. Получите от пользователя два целых числа.
2. Используя выражение, в котором тернарный оператор располагается слева от
оператора присвоения, выполните проверку на то, что первое введенное число
больше или равно второму.
3. (в том же выражении) Если проверка возвращает true – первому числу должно
присвоится значение 100, иначе 100 должно присвоится второму введенному
числу.
4. Выведите информацию о числах и их итоговых значениях на экран консоли.
*/
Console.WriteLine("Введите два целых числа \n");

Console.WriteLine("Введите первое число:");

int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");

int secondNumber = Convert.ToInt32(Console.ReadLine());

(firstNumber >= secondNumber ? ref firstNumber : ref secondNumber) = 100;

Console.WriteLine($"Первое число теперь равно {firstNumber}, а второе число равно {secondNumber}");

Console.ReadKey();
