using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.NikiforovFA.Sprint2.Task2.V29.Lib
{
    public class DataService : ISprint2Task2V29
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if (y < 3 | y > 12) return false;
            if (x > 13) return false;
            if (((x > 2 & x < 6) | (x > 8 & x < 13)) & (y == 3) | (((x > 0 & x < 6) | (x > 8 & x < 13)) & (y == 4)) | (((x > 0 & x < 13)) & (y == 5)) | (((x > 2 & x < 14)) & (y == 6)) | (((x > 2 & x < 14)) & (y == 7)) | (((x == 6) | (x > 9 & x < 14)) & (y == 8)) | (((x == 6) | (x > 9 & x < 13)) & (y == 9)) | (((x == 6) | (x > 9 & x < 13)) & (y == 10)) | (((x > 2 & x < 7) | (x > 9 & x < 13)) & (y == 11)) | (((x > 3 & x < 6) | x == 10) & (y == 12))) return true; else return false;
        }
    }
}
