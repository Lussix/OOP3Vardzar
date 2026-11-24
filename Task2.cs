using System;

namespace OOP3Vardzar
{
    internal class Task2
    {
        public static void Run()
        {
            Console.Write("Введіть текст: ");
            string text = Console.ReadLine()!;
            Console.Write("Скільки слів видалити: ");
            int x = int.Parse(Console.ReadLine()!);

            int wordNumber = 0;
            string result = "";

            for (int i = 0; i < text.Length; i++)
            {
                bool startOfWord = text[i] != ' ' && (i == 0 || text[i - 1] == ' ');

                if (startOfWord)
                {
                    wordNumber++;
                }

                if (wordNumber > x)
                {
                    result += text[i];
                }
            }

            Console.WriteLine("Результат: " + result);
        }
    }
}