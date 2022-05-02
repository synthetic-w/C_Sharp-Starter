/*
Имеется библиотека, в которой находится 5 стеллажей с книгами. Каждый стеллаж
является типовым – в нем имеется 10 полок и на каждой полке помещается по 10 книг.
Для хранения информации о том, на каком стеллаже, на какой полке и в каком месте
этой полки хранится книга – в библиотечной базе данных используется массив строк с
названиями книг.
Реализуйте такой способ хранения информации о книгах в вашей программе. В вашей
библиотеке на разных стеллажах, разных полках и разных местах на полках поместили 3
книги: «О дивный новый мир», «Приключения Тома Сойера» и «CLR via C#».

Напишите программу, в которой пользователь, введя название книги, может получить
информацию о ее расположении – номер стеллажа, номер полки и номер места на полке.

Теперь, дополнительно к предыдущему условию, библиотека состоит еще и из 3х одинаковых
комнат со стеллажами. В этой увеличенной библиотеке разместите три книги.
Напишите программу, в которой пользователь, введя название книги, может получить
информацию о ее расположении – номер комнаты, номер стеллажа, номер полки и
номер места на полке.
Дополнительно выведите на экран все имеющиеся в библиотеке книги.
 */

string[,,,] library = new string[3, 5, 10, 10];

Console.WriteLine("Введите количество книг:");
int bookCount = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < bookCount; i++)
{
    BookRandomizer(library);
}

Console.WriteLine(new String('=', 15));
Console.WriteLine("Введите название искомой книги:");

string bookName = Console.ReadLine();

BookPositionFinder(bookName, library);

Console.WriteLine(new String('=', 15));
Console.WriteLine("Книги, находящиеся в библиотеке:");

ShowLibraryContent(library);

// Поиск расположения книги по названию
static void BookPositionFinder(string bookName, string[,,,] library)
{
    for (int i = 0; i < library.GetLength(0); i++)
    {
        for (int j = 0; j < library.GetLength(1); j++)
        {
            for (int k = 0; k < library.GetLength(2); k++)
            {
                for (int l = 0; l < library.GetLength(3); l++)
                {
                    if (library[i, j, k, l] != null && library[i, j, k, l].ToLower() == bookName.ToLower())
                    {
                        Console.WriteLine($"Книга с названием {bookName} находится в {i + 1} комнате, в {j + 1} стеллаже, на {k + 1} полке и стоит {l + 1} номером");
                    }
                }
            }
        }
    }
}

// Расставление книг в рандомном порядке
static void BookRandomizer(string[,,,] library)
{
    Random random = new Random();

    int bookRoom = random.Next(library.GetLength(0) - 1);

    int bookStillage = random.Next(library.GetLength(1) - 1);

    int bookShelf = random.Next(library.GetLength(2) - 1);

    int bookPosition = random.Next(library.GetLength(3) - 1);

    Console.WriteLine("Введите название книги:");
    string bookName = Console.ReadLine();

    if (library[bookRoom, bookStillage, bookShelf, bookPosition] == null)
    {
        library[bookRoom, bookStillage, bookShelf, bookPosition] = bookName;
    }
    else
    {
        if (EmptyCellsPresence(library))
        {
            BookRandomizer(library);
        }
        else
        {
            Console.WriteLine("Библиотека заполнена");
            return;
        }
    }
}

// Проверка отсутствия хотя бы одного свободного места в массиве (библиотеке)
static bool EmptyCellsPresence(string[,,,] library)
{
    for (int i = 0; i < library.GetLength(0); i++)
    {
        for (int j = 0; j < library.GetLength(1); j++)
        {
            for (int k = 0; k < library.GetLength(2); k++)
            {
                for (int l = 0; l < library.GetLength(3); l++)
                {
                    if (library[i, j, k, l] != null)
                    {
                        return true;
                    }
                }
            }
        }
    }

    return false;
}

// Перечисление книг, находящихся в библиотеке
static void ShowLibraryContent(string[,,,] library)
{
    for (int i = 0; i < library.GetLength(0); i++)
    {
        for (int j = 0; j < library.GetLength(1); j++)
        {
            for (int k = 0; k < library.GetLength(2); k++)
            {
                for (int l = 0; l < library.GetLength(3); l++)
                {
                    if (library[i, j, k, l] != null)
                    {
                        Console.WriteLine(library[i, j, k, l]);
                    }
                }
            }
        }
    }
}

Console.ReadKey();