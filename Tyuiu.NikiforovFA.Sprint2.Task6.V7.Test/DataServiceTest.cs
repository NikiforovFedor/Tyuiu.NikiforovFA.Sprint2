using Tyuiu.NikiforovFA.Sprint2.Task6.V7.Lib;
namespace Tyuiu.NikiforovFA.Sprint2.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FindMonthNameValid()
        {
            DataService ds = new DataService();
            int x = 5;
            Assert.AreEqual(ds.FindMonthName(1990, x), "θώνό");
        }
    }
}