using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.NikiforovFA.Sprint2.Task3.V5.Lib
{
    public class DataService : ISprint2Task3V5
    {
        public double Calculate(double x)
        {
            double y = 0;
            if (x > 1)
            {
                y =  (Math.Round(x - Math.Pow((x + 1) / (x - 1), 2), 3));
            }
            else if (x == 0) 
            {
                y = (Math.Round(((x*x) - Math.Cos(x*x)/(x*x - Math.Sin(x*x) + 12)), 3));
            }
            else if (-9 < x & x < 0)
            {
                y = (Math.Round(Math.Pow(6 + 4/(x*x), x), 3));
            }
            else if (x < -9)
            {
                y = (Math.Round((x*x*x) + 10*x - ((x*x)/(x*x*x*x)), 3));
            }
            return y;
        }
    }
}
