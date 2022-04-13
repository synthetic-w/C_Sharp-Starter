/*
Напишите программу, в которой создайте два двумерных массива, по логике
задачи реализующих математические матрицы. Размерность массивов получите
от пользователя. Размерность массивов должна быть таковой, чтобы обеспечить
возможность умножения этих матриц. На это ограничение нужно выполнить
проверку.
При прохождении проверки, заполните массивы данными, получая их от
пользователя.
Выведите на экран результат умножения матриц
*/

Console.WriteLine("Программа умножения пользовательских матриц v1.0");
Console.WriteLine(new String(' ', 48));
Console.WriteLine(new String('_', 48));

Console.WriteLine("[Введите размерности первой матрицы]");

// 1 Блок ввода размерностей первой матрицы
int rowsA, columnsA;
{
    Console.Write("Введите количество столбцов в матрице:");
    columnsA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество строк в матрице:");
    rowsA = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(new String(' ', 48));
Console.WriteLine(new String('-', 48));
Console.WriteLine("[Введите размерности второй матрицы]");

// 2 Блок ввода размерностей второй матрицы
int columnsB, rowsB;
{
    Console.Write("Введите количество столбцов в матрице:");
    columnsB = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество строк в матрице:");
    rowsB = Convert.ToInt32(Console.ReadLine());
}

// 3 Блок проверки равентсва значения столбцов 1-й матрицы и строк 2-й
{
    if (columnsA == rowsB) {
        Console.WriteLine(new String(' ', 48));
        Console.WriteLine("Матрицы согласованы между собой");
        Console.WriteLine(new String(' ', 48));

        // 3.1 Создание двух матриц A и B и третьей с результатом умножения

        // 3.2 Заполнение первой матрицы вводом пользователя
        int[,] A = new int[rowsA, columnsA];
        for (int i = 0; i < A.GetLength(0); i++) {
            for (int j = 0; j < A.GetLength(1); j++) {
                Console.Write($"Введите значения элементов первого массива:");
                A[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine(new String(' ', 48));

        // 3.3 Заполнение второй матрицы вводом пользователя
        int[,] B = new int[rowsB, columnsB];
        for (int i = 0; i < B.GetLength(0); i++) {
            for (int j = 0; j < B.GetLength(1); j++) {
                Console.Write($"Введите значения элементов второго массива:");
                B[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        // 3.4 Непосредственное умножение матриц
        int[,] C = new int[A.GetLength(0), B.GetLength(1)];
        for (int i = 0; i < A.GetLength(0); i++) {
            for (int j = 0; j < B.GetLength(1); j++) {
                for (int k = 0; k < A.GetLength(0); k++) {
                    C[i, j] += A[i, k] * B[k, j];
                }
            }
        }

        // 3.5 Вывод результата произведения на экран
        Console.WriteLine(new String(' ', 48));
        Console.WriteLine("Результат умножения:");
        for (int i = 0; i < A.GetLength(0); i++) {
            for (int j = 0; j < B.GetLength(1); j++) {
                Console.Write($"{C[i, j]} ");
            }
            Console.WriteLine();
        }
    }
    else {
        Console.WriteLine("--Матрицы не согласованы между собой--\n" +
                          "        Произведение невыполнимо       ");
    }
}
Console.ReadKey();
