/*
Напишите программу, в которой:
1. получите от пользователя целое число.
2. Создайте массив целочисленных элементов, длиной с полученное число.
3. С помощью цикла и обращаясь за значениями к пользователю заполните массив
целочисленных элементов.
4. Отсортируйте массив по убыванию, после чего измените размер массива на +1
элемент.
5. Обратитесь к пользователю и заполните новый элемент массива значением от
пользователя.
*/
while (true)
{
    Console.WriteLine("Введите любое целое число:");

    // 1. Получение числа от пользователя
    int inputNumber = Convert.ToInt32(Console.ReadLine());

    // 2. Создание массива, длиной с полученное число
    int[] userArray = new int[inputNumber];

    // 3. Заполнение массива пользователем
    Console.WriteLine($"Теперь введите {inputNumber} элементов массива:");

    for (int index = 0; index < userArray.Length; index++)
    {
        userArray[index] = Convert.ToInt32(Console.ReadLine());
    }

    // 4. Сортировка массива по убыванию
    int tempValue;
    for (int first = 0; first < userArray.Length - 1; first++)
    {
        for (int second = first + 1; second < userArray.Length; second++)
        {
            if (userArray[first] < userArray[second])
            {
                tempValue = userArray[first];
                userArray[first] = userArray[second];
                userArray[second] = tempValue;
            }
        }
    }

    // 5. Добавление элемента массива
    Array.Resize(ref userArray, userArray.Length + 1);

    // Вывод элементов
    Console.WriteLine("Результат сортировки пользовательского массива по убыванию \n" +
                      "и увеличения массива на 1 элемент:");
    for (int index = 0; index < userArray.Length; index++)
    {
        Console.WriteLine(userArray[index]);
    }

    Console.WriteLine(new String('=', 20));
    Console.ReadKey();
}
