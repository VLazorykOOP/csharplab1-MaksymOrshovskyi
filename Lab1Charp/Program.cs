using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Лабораторна робота 1!");

        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
        Task6();
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

    static void Task4()
    {
        // Введення порядкового номера дня місяця від користувача
        Console.WriteLine("Введіть порядковий номер дня місяця:");
        int dayOfMonth = int.Parse(Console.ReadLine());

        // Визначення поточної дати
        DateTime currentDate = DateTime.Now;

        // Визначення кількості днів у місяці
        int daysInMonth = DateTime.DaysInMonth(currentDate.Year, currentDate.Month);

        // Визначення кількості днів, що залишилися до кінця місяця
        int daysLeftInMonth = daysInMonth - dayOfMonth;

        // Виведення результату
        Console.WriteLine("До кінця місяця залишилося {0} днів.", daysLeftInMonth);
    }

    static void Task5()
    {
        // Введення двох цілих чисел від користувача
        Console.WriteLine("Введіть два цілих числа:");
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());

        // Виклик функції для обчислення різниці між числами та виведення результату
        int difference = CalculateDifference(a, b);
        Console.WriteLine("Різниця між числами: " + difference);
    }

    static void Task6()
    {
        // Зчитування значення x з клавіатури
        Console.WriteLine("Введіть значення x:");
        double x = double.Parse(Console.ReadLine());

        // Зчитування значення y з клавіатури
        Console.WriteLine("Введіть значення y:");
        double y = double.Parse(Console.ReadLine());

        // Обчислення виразу
        double result = ((1 / (x * y)) + (1 / (x * x + 1))) * (x + y);

        // Виведення результату
        Console.WriteLine("Результат виразу: " + result);
    }

    // Функція для обчислення різниці між двома цілими числами
    static int CalculateDifference(int a, int b)
    {
        return a - b;
    }
}
