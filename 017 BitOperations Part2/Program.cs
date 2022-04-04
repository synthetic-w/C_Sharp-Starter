using System;

namespace _007_BitOperations_Part2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите символ:");
            string inputString = Console.ReadLine();
            char charFromString = Convert.ToChar(inputString);

            int key = 216; // Ключ шифрования

            char encryptedChar = (char)(charFromString ^ key); // Процесс шифрования
            Console.WriteLine($"Результат кодирования: {encryptedChar}");

            char decryptedChar = (char)(encryptedChar ^ key);
            Console.WriteLine($"Дешифровка символа: {decryptedChar}"); // Процесс дешифровки

            Console.ReadKey();
        }
    }
}
