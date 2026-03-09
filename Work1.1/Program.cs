using System;

class Program
{
    static void Main()
    {
        // Явно задаём три различных числа
        int a = 7;
        int b = 2;
        int c = 5;

        // Переменные для хранения двух наименьших чисел
        int min1, min2;

        // Поиск наименьшего числа и второго по величине
        if (a < b && a < c)
        {
            // a — наименьшее
            min1 = a;
            // Второе наименьшее — меньшее из b и c
            if (b < c)
                min2 = b;
            else
                min2 = c;
        }
        else if (b < a && b < c)
        {
            // b — наименьшее
            min1 = b;
            // Второе наименьшее — меньшее из a и c
            if (a < c)
                min2 = a;
            else
                min2 = c;
        }
        else
        {
            // c — наименьшее
            min1 = c;
            // Второе наименьшее — меньшее из a и b
            if (a < b)
                min2 = a;
            else
                min2 = b;
        }

        // Вычисление произведения
        int product = min1 * min2;

        // Вывод результата
        Console.WriteLine("Заданные числа: {0}, {1}, {2}", a, b, c);
        Console.WriteLine("Два наименьших числа: {0} и {1}", min1, min2);
        Console.WriteLine("Их произведение: {0}", product);
    }
}