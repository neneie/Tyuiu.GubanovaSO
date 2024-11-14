using Tyuiu.GubanovaSO.Sprint4.Task7.V22.Lib;

namespace Tyuiu.GubanovaSO.Sprint4.Task7.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string v = "695324951753684";
            int n = 5, m = 3;
            DataService ds = new DataService();
            int res = 6*2*4*6*8*4;
            Assert.AreEqual(res, ds.Calculate(n, m, v));
        }
    }
}