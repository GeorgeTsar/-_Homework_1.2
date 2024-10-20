using System;
using System.Reflection.PortableExecutable;

internal class Program
{
    private static void Main(string[] args)
    {
        #region ЗАДАНИЕ 1

        int a;
        Console.WriteLine("Введите целое число из диапазона от 1 до 100: ");
        a = int.Parse(Console.ReadLine());
        if (a % 3 == 0 && a % 5 == 0)
        {
            Console.WriteLine("Fizz Buzz");
        }
        else if (a % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (a % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine(a);
        }


        #endregion

        #region ЗАДАНИЕ 2

        int a, b;
        Console.WriteLine("Введите значение: ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите процент: ");
        b = int.Parse(Console.ReadLine());
        int res = b * a / 100;
        Console.Write("Результат: ");
        Console.Write(res);

        #endregion

        #region ЗАДАНИЕ 3

        int a, b, c, d;
        Console.WriteLine("Введите первое число: ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите третье число: ");
        c = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите четвёртое число: ");
        d = int.Parse(Console.ReadLine());
        int first = a * 1000;
        int second = b * 100;
        int third = c * 10;
        int res = first + second + third + d;
        Console.Write("Результат: ");
        Console.Write(res);

        #endregion

        #region ЗАДАНИЕ 4

        int a, fist, two, five, six, osn;
        Console.WriteLine("Введите 6-значное число: ");
        if (a % 1000000 == a)
        {
            six = a % 10;
            five = (a % 100) / 10;
            fist = (a % 1000000) / 100000;
            two = (a % 100000) / 10000;
            osn = (a % 10000) / 100;
            Console.WriteLine("Исходное число: " + six + five + osn + two + fist);
        }
        else Console.WriteLine("Введено не 6-значное число!");

        #endregion

        #region ЗАДАНИЕ 5

        double a, b, c;
        Console.WriteLine("Введите день: ");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите месяц: ");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите год: ");
        c = double.Parse(Console.ReadLine());

        if (b == 1 || b == 2 || b == 12)
        {
            Console.WriteLine("Зима");
        }
        else if (b == 3 || b == 4 || b == 5)
        {
            Console.WriteLine("Весна");
        }
        else if (b == 6 || b == 7 || b == 8)
        {
            Console.WriteLine("Лето");
        }
        else
        {
            Console.WriteLine("Осень");
        }

        #endregion

        #region ЗАДАНИЕ 6

        int a;
        Console.WriteLine("Введите показания температуры: ");
        a = int.Parse(Console.ReadLine());
        int i;
        Console.WriteLine("Показать температуру по Цельсию (1) или по Фаренгейту (2) ?");
        i = int.Parse(Console.ReadLine());
        int res = 0;
        if (i == 1)
        {
            res = (a - 30) / 2;
        }
        else if (i == 2)
        {
            res = (a * 2) + 30;
        }
        Console.Write("Результат: ");
        Console.Write(res);

        #endregion

        #region ЗАДАНИЕ 7

        int a, b;
        Console.WriteLine("Введите начало диапазона: ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите конец диапазона: ");
        b = int.Parse(Console.ReadLine());
        if (a > b)
        {
            int temp = a;
            b = temp;
            a = b;
        }
        for (int i = 0; i <= b; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i);
                Console.Write('\t');
            }
        }


        #endregion





    }

}
