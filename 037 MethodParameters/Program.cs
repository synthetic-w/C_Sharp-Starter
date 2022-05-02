/*
Напишите программу, в которой создайте три метода.

Первый метод - принимает три целых числа и возвращает сумму этих чисел.

Второй метод принимает три целочисленных ref параметра, увеличивает каждый из
полученных параметров на единицу, а затем возвращает сумму этих увеличенных
значений.

Третий метод в качестве параметров принимает три целых числа и булево значение,
и возвращает целочисленное значение. Если булевый параметр содержит значение
true – третий метод вызовет метод №1 и передаст ему значения своих числовые
параметров, иначе - если булевый параметр содержит значение false - третий метод
в своем теле вызовет метод №2 и передаст ему свои числовые параметры.
Выведите на экран результат выполнения метода №3 и значение его параметров.
 */

int firstNumber = 2, secondNumber = 2, thirdNumber = 8;
bool b00l = false;

int result = ThirdMethod(firstNumber, secondNumber, thirdNumber, b00l);

Console.WriteLine($"Результат выполнения третьего метода: {result}");

Console.WriteLine($"Значения параметров: {firstNumber}, {secondNumber}, {thirdNumber}");

static void NumbersSummary(int firstNumber, int secondNumber, int thirdNumber, out int result)
{
    Console.WriteLine($"Значения параметров метода NumbersSummary: {firstNumber}, {secondNumber}, {thirdNumber}");
    result = firstNumber + secondNumber + thirdNumber;
}

int RefIncrement(ref int firstNumber, ref int secondNumber, ref int thirdNumber)
{
    firstNumber++;
    secondNumber++;
    thirdNumber++;
    Console.WriteLine($"Значения параметров метода RefIncrement: {firstNumber}, {secondNumber}, {thirdNumber}");
    return firstNumber + secondNumber + thirdNumber;
}

int ThirdMethod(int firstNumber, int secondNumber, int thirdNumber, bool b00l)
{
    if (b00l)
    {
        Console.WriteLine($"Значения параметров метода ThirdMethod (блок if): {firstNumber}, {secondNumber}, {thirdNumber}");
        NumbersSummary(firstNumber, secondNumber, thirdNumber, out result);

        return result;
    }
    else
    {
        Console.WriteLine($"Значения параметров метода ThirdMethod (блок else): {firstNumber}, {secondNumber}, {thirdNumber}");
        return RefIncrement(ref firstNumber, ref secondNumber, ref thirdNumber);
    }
}

//Console.ReadKey();