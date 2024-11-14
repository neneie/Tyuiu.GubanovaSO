using Tyuiu.GubanovaSO.Sprint4.Task4.V24.Lib;

namespace Tyuiu.GubanovaSO.Sprint4.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] arr =
            {
                {7, 9, 7, 6, 7 },
                {9, 9, 8, 6, 7 },
                {8, 6, 5, 6, 7 },
                {9, 9, 7, 8, 7 },
                {5, 9, 9, 8, 9 }
            };
            int[,] res = ds.Calculate(arr);
            Assert.AreEqual(1, res[0,3]);
        }
    }
}