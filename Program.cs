using System;

namespace OOPBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Яке завдання запустити? Введіть 1, 2, 3 або 4:");
            int taskNumber = int.Parse(Console.ReadLine()!);

            if (taskNumber == 1)
            {
                Console.WriteLine("Тут буде завдання 1");
            }
            else if (taskNumber == 2)
            {
                Console.WriteLine("Тут буде завдання 2");
            }
            else if (taskNumber == 3)
            {
                Console.WriteLine("Тут буде завдання 3");
            }
            else if (taskNumber == 4)
            {
                Console.WriteLine("Тут буде завдання 4");
            }
            else
            {
                Console.WriteLine("Немає такого завдання.");
            }

            Console.ReadLine();
        }
    }
}