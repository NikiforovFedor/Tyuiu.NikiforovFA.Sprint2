using Tyuiu.NikiforovFA.Sprint2.Task3.V5.Lib;
namespace Tyuiu.NikiforovFA.Sprint2.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateValid()
        {
            DataService ds = new DataService();
            int x = 2;
            Assert.AreEqual(-7, ds.Calculate(x));
        }
    }
}