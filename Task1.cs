using System;

namespace OOP3Vardzar
{
    internal class Task1
    {
        public static void Run()
        {
            Console.Write("Введіть ціле число: ");
            long n = long.Parse(Console.ReadLine()!);

            bool negative = n < 0;
            if (negative)
            {
                n = -n;
            }

            long reversed = 0;
            while (n > 0)
            {
                reversed = reversed * 10 + n % 10;
                n = n / 10;
            }

            if (negative)
            {
                reversed = -reversed;
            }

            Console.WriteLine("Результат: " + reversed);
        }
    }
}