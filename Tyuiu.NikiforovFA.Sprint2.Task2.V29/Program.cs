using Tyuiu.NikiforovFA.Sprint2.Task2.V29.Lib;
namespace Tyuiu.NikiforovFA.Sprint2.Task2.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Никифоров Ф. А | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Никифоров Федор Александрович | ПКТб-24-1                     *");
            Console.WriteLine("* Задание:                                                                *");
            Console.WriteLine("* Определить, находится ли точка в закрашенной области                    *");
            Console.WriteLine("***************************************************************************");
            int x, y;
            Console.WriteLine("Введите X: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Y: ");
            y = Convert.ToInt32(Console.ReadLine());
            bool res = ds.CheckDotInShadedArea(x,y);
            if (ds.CheckDotInShadedArea(x,y) == true) Console.WriteLine("Точка находится в закрашенной области");
            else Console.WriteLine("Точка находится вне закрашенной зоны");
        }
    }
}
