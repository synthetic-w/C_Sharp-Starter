/*
Напишите программу, в которой получите целое число и используя циклическую
конструкцию выведите на экран консоли все числа от введенного и до нуля
включительно.
*/

Console.WriteLine("Введите любое целое число:");

int inputNumber = Convert.ToInt32(Console.ReadLine());

if (inputNumber > 0)
{
    while (inputNumber >= 0)
    {
        Console.WriteLine($"Минус один {inputNumber}");

        inputNumber--;
    }
}
else if (inputNumber < 0)
{
    while (inputNumber <= 0)
    {
        Console.WriteLine($"Плюс один {inputNumber}");

        inputNumber++;
    }
}

Console.ReadKey();