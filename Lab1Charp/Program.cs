// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()
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
}

// continue ...
