using Tyuiu.NikiforovFA.Sprint2.Task3.V5.Lib;
namespace Tyuiu.NikiforovFA.Sprint2.Task3.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Никифоров Ф. А | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Никифоров Федор Александрович | ПКТб-24-1                     *");
            Console.WriteLine("* Задание:                                                                *");
            Console.WriteLine("* Определить значение y через х, который вводит пользователь              *");
            Console.WriteLine("***************************************************************************");
            double x;
            Console.WriteLine("Введите х: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ответ: {0}", ds.Calculate(x));

        }
    }
}
