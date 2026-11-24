using System;

namespace OOP3Vardzar

{
    internal class Task4
    {
        public static void Run()
        {
            Console.Write("Введіть текст: ");
            string text = Console.ReadLine()!;

            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                int position = i + 1;

                if (position % 15 == 0)
                {
                    result += "?";
                }
                else if (position % 5 == 0)
                {
                    result += "9";
                }
                else if (position % 3 == 0)
                {
                    result += "X";
                }
                else
                {
                    result += text[i];
                }
            }

            Console.WriteLine("Результат: " + result);
        }
    }
}