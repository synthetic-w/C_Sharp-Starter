/*
Напишите программу, в которой получите от пользователя два целых числа.
Используя цикл выведите все нечетные числа, расположенные между введенными
числами.
*/

Console.WriteLine("Введите первое число:");

int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");

int secondtNumber = Convert.ToInt32(Console.ReadLine());

int minValue, maxValue;

if (firstNumber > secondtNumber) {
    minValue = secondtNumber;
    maxValue = firstNumber;
}
else {
    minValue = firstNumber;
    maxValue = secondtNumber;
}

Console.WriteLine(new String('=', 50));

while (minValue <= maxValue) {
    if (minValue % 2 != 0) {
        Console.WriteLine(minValue);
        minValue += 2;
    }
    else {
        minValue++;
    }
}

Console.ReadKey();
