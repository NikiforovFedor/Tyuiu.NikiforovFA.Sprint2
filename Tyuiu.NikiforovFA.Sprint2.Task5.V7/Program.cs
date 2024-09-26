using Tyuiu.NikiforovFA.Sprint2.Task5.V7.Lib;
namespace Tyuiu.NikiforovFA.Sprint2.Task5.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Никифоров Ф.А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Никифоров Федор Александрович | ПКТб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая вычисляет значение с       *");
            Console.WriteLine("* с помощью oператорa switch                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            int n, y;
            Console.WriteLine("Введите n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine(ds.FindMonthName(n, y));
        }
    }
}
