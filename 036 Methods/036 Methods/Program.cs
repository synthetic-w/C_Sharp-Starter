/*
Пользователь вводит количество сотрудников предприятия, стоимость 1 трудодня
сотрудника и количество дней, за которые производится оплата.

Создайте метод, который считает зарплату рабочему, исходя из количества дней и
подневной оплаты труда. Создайте метод, который принимает в себя количество
сотрудников, количество рабочих дней и цену трудодня, и вычисляет общий объем
денег, необходимый для оплаты полученному количеству сотрудников, используя
внутри себя первый метод.

Посчитайте и выведите на экран общий объем денег, необходимый для оплаты
зарплаты введенному пользователем количеству сотрудников.
 */

Console.WriteLine("Введите количество сотрудников");
int employees = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите стоимость трудодня для одного сотрудника");
int dailySalary = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество дней, за которые производится оплата");
int workDays = Convert.ToInt32(Console.ReadLine());

int totalSalary = SalariesSummary(workDays, dailySalary, employees);
Console.WriteLine($"Общая зарплата работников за {workDays} дня/дней составит {totalSalary}");

Console.ReadKey();

// Зарплата одного сотрудника
int EmployerSalary(int workDays, int dailySalary)
{
    return workDays * dailySalary;
}

// Рассчёт общего объема зарплаты сотрудников
int SalariesSummary(int workDays, int dailySalary, int employees)
{
    int employerSalary = EmployerSalary(workDays, dailySalary);
    return employerSalary * employees;
}