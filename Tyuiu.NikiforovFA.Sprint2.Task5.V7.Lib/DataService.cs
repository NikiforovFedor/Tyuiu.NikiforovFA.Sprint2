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
                case 0: m = "Январь"; break;
                case 1: m = "Февраль"; break;
                case 2: m = "Март"; break;
                case 3: m = "Апрель"; break;
                case 4: m = "Май"; break;
                case 5: m = "Июнь"; break;
                case 6: m = "Июль"; break;
                case 7: m = "Август"; break;
                case 8: m = "Сентябрь"; break;
                case 9: m = "Октябрь"; break;
                case 10: m = "Ноябрь"; break;
                case 11: m = "Декабрь"; break;
            }
            return m;

        }
    }
}
