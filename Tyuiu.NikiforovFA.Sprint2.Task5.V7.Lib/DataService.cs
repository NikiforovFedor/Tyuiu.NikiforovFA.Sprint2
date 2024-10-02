using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.NikiforovFA.Sprint2.Task5.V7.Lib
{
    public class DataService : ISprint2Task5V7
    {
        public string FindMonthName(int startYear, int n)
        {
            string m = "";
            if (n > 12)
            {
                n %= 12;
            }
            switch (n)
            {
                case 0: m = "январь"; break;
                case 1: m = "февраль"; break;
                case 2: m = "март"; break;
                case 3: m = "апрель"; break;
                case 4: m = "май"; break;
                case 5: m = "июнь"; break;
                case 6: m = "июль"; break;
                case 7: m = "август"; break;
                case 8: m = "сентябрь"; break;
                case 9: m = "октябрь"; break;
                case 10: m = "ноябрь"; break;
                case 11: m = "декабрь"; break;
            }
            return m;

        }
    }
}
