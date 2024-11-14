using Tyuiu.GubanovaSO.Sprint4.Task1.V26.Lib;

namespace Tyuiu.GubanovaSO.Sprint4.Task1.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 7, 7, 8, 8, 2, 6, 3, 3, 3, 1 };
            int res = 24;
            Assert.AreEqual(res, ds.Calculate(array));
        }
    }
}