using Tyuiu.NikiforovFA.Sprint2.Task7.V3.Lib;
namespace Tyuiu.NikiforovFA.Sprint2.Task7.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Никифоров Ф.А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Итоговый проект по спринту                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Никифоров Федор Александрович | ПКТб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая вычисляет, находится ли    *");
            Console.WriteLine("* точка в закрашенной зоне.                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            double x, y;
            Console.WriteLine("* Введите Х:                                                              *");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("* Введите Y:                                                              *");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine(ds.CheckDotInShadedArea(x, y));
        }
    }
}
