using System;

namespace OOP3Vardzar
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
                Task1.Run();
            }
            else if (taskNumber == 2)
            {
                Task2.Run();
            }
            else if (taskNumber == 3)
            {
                Task3.Run();
            }
            else if (taskNumber == 4)
            {
                Task4.Run();
            }
            else
            {
                Console.WriteLine("Немає такого завдання.");
            }

            Console.ReadLine();
        }
    }
}