using Tyuiu.NikiforovFA.Sprint2.Task2.V29.Lib;
namespace Tyuiu.NikiforovFA.Sprint2.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckDotInShadedAreaValid()
        {
            DataService ds = new DataService();
            int x = 3, y = 3;
            Assert.AreEqual(true, ds.CheckDotInShadedArea(x,y));
        }
    }
}