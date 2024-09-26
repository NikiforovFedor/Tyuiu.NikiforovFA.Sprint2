using Tyuiu.NikiforovFA.Sprint2.Task0.V3.Lib;
namespace Tyuiu.NikiforovFA.Sprint2.Task0.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Никифоров Ф. А | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Никифоров Федор Александрович | ПКТб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дано:                                                                   *");
            Console.WriteLine("* x = 45, y = 127                                                         *");
            Console.WriteLine("***************************************************************************");
            int x = 43, y = 127;
            Console.WriteLine("x = {0}, y = {1}", x, y);
            Console.WriteLine("* Результат:                                                              *");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(ds.GetCompareOperations(x,y)[i]);
            }
        }
    }
}
