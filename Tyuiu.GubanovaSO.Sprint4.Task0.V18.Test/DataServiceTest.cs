using Tyuiu.GubanovaSO.Sprint4.Task0.V18.Lib;

namespace Tyuiu.GubanovaSO.Sprint4.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };
            int res = 41;
            Assert.AreEqual(res, ds.GetSumOddArrEl(array));
        }
    }
}

