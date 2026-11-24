using System;

namespace OOP3Vardzar
{
    internal class Task3
    {
        public static void Run()
        {
            double pi = 3.14159;

            Console.WriteLine("Площу якої фігури порахувати?");
            Console.WriteLine("1. Квадрат");
            Console.WriteLine("2. Круг");
            Console.WriteLine("3. Прямокутник");
            Console.WriteLine("4. Трикутник");
            int figure = int.Parse(Console.ReadLine()!);

            if (figure == 1)
            {
                Console.Write("Введіть сторону: ");
                double side = double.Parse(Console.ReadLine()!);
                Console.WriteLine("Площа: " + side * side);
            }
            else if (figure == 2)
            {
                Console.Write("Введіть радіус: ");
                double r = double.Parse(Console.ReadLine()!);
                Console.WriteLine("Площа: " + pi * r * r);
            }
            else if (figure == 3)
            {
                Console.Write("Введіть першу сторону: ");
                double a = double.Parse(Console.ReadLine()!);
                Console.Write("Введіть другу сторону: ");
                double b = double.Parse(Console.ReadLine()!);
                Console.WriteLine("Площа: " + a * b);
            }
            else if (figure == 4)
            {
                Console.Write("Введіть основу: ");
                double baseLength = double.Parse(Console.ReadLine()!);
                Console.Write("Введіть висоту: ");
                double height = double.Parse(Console.ReadLine()!);
                Console.WriteLine("Площа: " + baseLength * height / 2);
            }
            else
            {
                Console.WriteLine("Немає такої фігури.");
            }
        }
    }
}