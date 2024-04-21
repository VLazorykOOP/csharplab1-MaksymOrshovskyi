using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Лабораторна робота 1!");

        Task1();
        Task2();
        Task3();
    }

    static void Task1()
    {
        double perimeter;

        // Введення периметру від користувача
        Console.WriteLine("Введіть периметр трикутника:");
        while (!double.TryParse(Console.ReadLine(), out perimeter) || perimeter <= 0)
        {
            Console.WriteLine("Введіть коректне значення периметру (позитивне число):");
        }

        // Знаходження довжини сторони рівностороннього трикутника
        double sideLength = perimeter / 3;

        // Обчислення площі трикутника
        double area = Math.Sqrt(3) / 4 * sideLength * sideLength;

        // Виведення результату
        Console.WriteLine("Площа рівностороннього трикутника з периметром {0} дорівнює {1}", perimeter, area);
    }

    static void Task2()
    {
        int number;

        // Введення числа від користувача
        Console.WriteLine("Введіть ціле число:");
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Введіть коректне ціле число:");
        }

        // Перевірка, чи є число парним
        if (number % 2 == 0)
        {
            Console.WriteLine("Число {0} є парним.", number);
        }
        else
        {
            Console.WriteLine("Число {0} не є парним.", number);
        }
    }

    static void Task3()
    {
        // Задані координати центру півкола та радіус
        double centerX = 0;
        double centerY = 0;
        double radius = 9;

        // Введення координат точки від користувача
        Console.WriteLine("Введіть координати точки (x, y):");
        Console.Write("x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        double y = double.Parse(Console.ReadLine());

        // Перевірка, чи потрапляє точка в півколо
        bool isInSemicircle = x >= centerX && y >= centerY && Math.Pow(x - centerX, 2) + Math.Pow(y - centerY, 2) <= Math.Pow(radius, 2);

        // Виведення результату
        if (isInSemicircle)
        {
            Console.WriteLine("Так");
        }
        else
        {
            Console.WriteLine("Ні");
        }
    }
}
