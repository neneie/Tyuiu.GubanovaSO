using Tyuiu.GubanovaSO.Sprint4.Task6.V2.Lib;

namespace Tyuiu.GubanovaSO.Sprint4.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ResultLengthValid()
        {
            DataService ds = new DataService();
            string[] names = new string[] { "Белый", "Черный", "Зеленый", "Синий", "Красный", "Желтый", "Фиолетовый" };
            string[] wait = { "Черный", "Зеленый", "Красный", "Желтый", "Фиолетовый" };
            string[] res = ds.Calculate(names);
            Assert.AreEqual(wait.Length, res.Length);
        }
    }
}