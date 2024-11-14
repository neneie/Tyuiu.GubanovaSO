using Tyuiu.GubanovaSO.Sprint4.Task6.V2.Lib;

namespace Tyuiu.GubanovaSO.Sprint4.Task6.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string[] names = new string[] { "Белый", "Черный", "Зеленый", "Синий", "Красный", "Желтый", "Фиолетовый" };
            Console.Title = "Спринт #4 | Выполнил: Губанова С.О. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Губанова Софья | ИБКСб-24-1                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных, используя класс Array,                     *");
            Console.WriteLine("* выведите элементы массива, длина которых больше 5 символов.             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* { \"Белый\", \"Черный\", \"Зеленый\", \"Синий\", \"Красный\", \"Желтый\", \"Фиолетовый\" }     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            string[] res = ds.Calculate(names);

            Console.Write("Элементы массива, имеющие длину больше 5 символов: ");
            for (int i = 0; i < res.Length; i++) { Console.Write(res[i] + " "); }
            Console.ReadLine();
        }
    }
}
