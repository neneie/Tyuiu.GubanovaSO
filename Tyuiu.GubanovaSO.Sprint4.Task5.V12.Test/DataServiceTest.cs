using Tyuiu.GubanovaSO.Sprint4.Task5.V12.Lib;

namespace Tyuiu.GubanovaSO.Sprint4.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] arr = new int[,]
            {
                {1, 3, -5, -4, 2 },
                {1, -6, -5, -4, -3 },
                {-1, 1, -5, -4, 3 },
                {1, 4, -5, -4, 4 },
                {1, -6, -5, -4, 2 }
            };
            int res = ds.Calculate(arr);
            Assert.AreEqual(14, res);
        }
    }
}