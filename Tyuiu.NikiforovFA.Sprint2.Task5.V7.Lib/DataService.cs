using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.NikiforovFA.Sprint2.Task5.V7.Lib
{
    public class DataService : ISprint2Task5V7
    {
        public string FindMonthName(int startYear, int n)
        {
            double y = n % 12;
            string m = "";
            if (n > 12)
            {
                switch (y)
                {
                    case 1: m = "Январь"; break;
                    case 2: m = "Февраль"; break;
                    case 3: m = "Март"; break;
                    case 4: m = "Апрель"; break;
                    case 5: m = "Май"; break;
                    case 6: m = "Июнь"; break;
                    case 7: m = "Июль"; break;
                    case 8: m = "Август"; break;
                    case 9: m = "Сентябрь"; break;
                    case 10: m = "Октябрь"; break;
                    case 11: m = "Ноябрь"; break;
                    case 12: m = "Декабрь"; break;
                }
                return m;
            }
            else
            {
                switch (n)
                {
                    case 1: m = "Январь"; break;
                    case 2: m = "Февраль"; break;
                    case 3: m = "Март"; break;
                    case 4: m = "Апрель"; break;
                    case 5: m = "Май"; break;
                    case 6: m = "Июнь"; break;
                    case 7: m = "Июль"; break;
                    case 8: m = "Август"; break;
                    case 9: m = "Сентябрь"; break;
                    case 10: m = "Октябрь"; break;
                    case 11: m = "Ноябрь"; break;
                    case 12: m = "Декабрь"; break;
                }
                return m;
            }
            
        }
    }
}
