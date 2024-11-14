using Tyuiu.GubanovaSO.Sprint4.Task3.V30.Lib;

namespace Tyuiu.GubanovaSO.Sprint4.Task3.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] nums = {
                { 2, 4, 3, 5, 1 },
                { 6, 6, 1, 2, 6 },
                { 3, 3, 2, 1, 5 },
                { 6, 4, 1, 3, 3 },
                { 5, 1, 1, 6, 4 } };
            int res = ds.Calculate(nums);
            Assert.AreEqual(5, res);
        }
    }
}