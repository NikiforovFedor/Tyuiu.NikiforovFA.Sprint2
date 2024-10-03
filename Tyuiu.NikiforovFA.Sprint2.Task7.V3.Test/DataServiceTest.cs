using Tyuiu.NikiforovFA.Sprint2.Task7.V3.Lib;
namespace Tyuiu.NikiforovFA.Sprint2.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckDotInShadedAreaValid()
        {
            DataService ds = new DataService();
            double x = 0.3, y = 0.3;
            Assert.AreEqual(ds.CheckDotInShadedArea(x, y), true);
        }
    }
}