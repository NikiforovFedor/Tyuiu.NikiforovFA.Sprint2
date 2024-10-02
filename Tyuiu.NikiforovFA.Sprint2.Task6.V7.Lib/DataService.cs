using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.NikiforovFA.Sprint2.Task6.V7.Lib
{
    public class DataService : ISprint2Task6V7
    {
        public string FindMonthName(int startYear, int n)
        {
            if (n > 12)
            {
                n %= 12;
            }
            string m = n switch
            {
                0 => m = "январь",
                1 => m = "февраль",
                2 => m = "март",
                3 => m = "апрель",
                4 => m = "май",
                5 => m = "июнь",
                6 => m = "июль",
                7 => m = "август",
                8 => m = "сентябрь",
                9 => m = "октябрь",
                10 => m = "ноябрь",
                11 => m = "декабрь",
                _ => m = "Ошибка!"
            };
            return m;

        }
    }
}
