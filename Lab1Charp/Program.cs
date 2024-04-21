using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Лабораторна робота 1!");

        Task1();
        Task2();
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
}
