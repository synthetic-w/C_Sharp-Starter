/*
За каждый месяц банк начисляет к сумме вклада 7% от суммы. Напишите консольную программу, в которую пользователь вводит сумму вклада и количество месяцев.
А банк вычисляет конечную сумму вклада с учетом начисления процентов за каждый месяц.

Для вычисления суммы с учетом процентов используйте цикл for.
Для ввода суммы вклада используйте выражение Convert.ToDecimal(Console.ReadLine()) (сумма вклада будет представлять тип decimal).
*/
Console.WriteLine("Введите сумму вклада:");

decimal depositValue = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Введите количество месяцев:");

int monthCounter = Convert.ToInt32(Console.ReadLine());

const decimal PCT = 0.07M;

while (monthCounter > 0) {
    depositValue += depositValue * PCT;
    monthCounter--;
}

Console.WriteLine($"Итоговая сумма вклада \n" +
   $"с учётом процентов за все месяцы: {Math.Round(depositValue, 2)}");

Console.ReadKey();
