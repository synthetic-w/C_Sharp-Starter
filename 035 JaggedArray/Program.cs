/*
Напишите программу, в которой получите от пользователя некий объем текста.
Сохраните этот текст в виде зубчатого массива, каждый элемент которого – массив
строк. Каждый массив строк должен представлять собой набор строковых элементов,
составляющих одно предложение общего текста, введенного пользователем, в
котором слова разделены пробелами.
Выведите на экран все слова, сохраненные в структуре зубчатого массива и его
элементов
*/
Console.WriteLine("Введите более 2-х предложений");

// Ввод текста
string sampleText = Console.ReadLine();

char[] separators = { '.', '!', '?' };

// Разбиение текста на массив предложений
string[] sentences = sampleText.Split(separators, StringSplitOptions.RemoveEmptyEntries);

// Создание зубчатого массива, длиной в количество предложений
string[][] wordsInSentences = new string[sentences.Length][];

// Перебор массива предложений
for (int i = 0; i < sentences.Length; i++)
{
    // Разбиение предложения на массив строк через пробел
    string[] words = sentences[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);

    // Присвоение массива слов в зубчатый массив с индексом предложения
    wordsInSentences[i] = words;
}
// Лица сишарповых представили? Не понял, нюхай бебру.

// Вывод полученного зубчатого массива: каждое слово на отдельной строке, после конца каждого предложения пишется 10 знаков '='
for (int i = 0; i < wordsInSentences.Length; i++)
{
    for (int j = 0; j < wordsInSentences[i].Length; j++)
    {
        Console.WriteLine(wordsInSentences[i][j].Trim(','));
    }

    Console.WriteLine(new String('=', 10));
}

Console.ReadKey();