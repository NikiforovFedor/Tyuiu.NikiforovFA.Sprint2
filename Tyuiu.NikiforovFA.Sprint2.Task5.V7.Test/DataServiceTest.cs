using Tyuiu.NikiforovFA.Sprint2.Task5.V7.Lib;
namespace Tyuiu.NikiforovFA.Sprint2.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void FindMonthNameValid()
        {
            int x = 5;
            Assert.AreEqual(ds.FindMonthName(1990, x), "Май");
        }
    }
}