using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.NikiforovFA.Sprint2.Task7.V3.Lib
{
    public class DataService : ISprint2Task7V3
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((((x * x) + Math.Pow((y-1),2)) <= 1) && (y <= 1 - (x * x)) && ((y >= 0 && y <= 1) && (x > -0.8 && x < 0.8)))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
