using Tyuiu.GubanovaSO.Sprint4.Task2.V25.Lib;

namespace Tyuiu.GubanovaSO.Sprint4.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 7, 8, 3, 4, 5, 1, 7, 3, 7, 5, 3 };
            int res = ds.Calculate(array);
            Assert.AreEqual(res, 32);
        }
    }
}