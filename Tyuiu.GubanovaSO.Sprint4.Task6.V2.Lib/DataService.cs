using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GubanovaSO.Sprint4.Task6.V2.Lib
{
    public class DataService: ISprint4Task6V2
    {
        public string[] Calculate(string[] array)
        {
            string[] result = Array.FindAll(array, s => s.Length > 5);
            return result;
        }
    }
}
