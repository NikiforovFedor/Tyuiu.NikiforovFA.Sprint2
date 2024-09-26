using Tyuiu.NikiforovFA.Sprint2.Task0.V3.Lib;
namespace Tyuiu.NikiforovFA.Sprint2.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetCompareOperationsValid()
        {
            DataService ds = new DataService();
            int x = 45;
            int y = 127;
            bool[] res = new bool[6];
            bool[] wait = { false, true, false, true, false, true };
            res = ds.GetCompareOperations(x, y);
            CollectionAssert.AreEqual(res, wait);

        }
    }
}