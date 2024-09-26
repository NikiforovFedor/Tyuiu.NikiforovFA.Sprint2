﻿using Tyuiu.NikiforovFA.Sprint2.Task4.V3.Lib;
namespace Tyuiu.NikiforovFA.Sprint2.Task4.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Никифоров Ф.А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Никифоров Федор Александрович | ПКТб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая вычисляет значение с       *");
            Console.WriteLine("* с помощью тернарного оператора                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            double x, y;
            Console.WriteLine("Введите х: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine(ds.Calculate(x, y));

        }
    }
}
