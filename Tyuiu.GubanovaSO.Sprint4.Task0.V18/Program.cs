using Tyuiu.GubanovaSO.Sprint4.Task0.V18.Lib;

namespace Tyuiu.GubanovaSO.Sprint4.Task0.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[] array = new int[] { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };
            Console.Title = "Спринт #4 | Выполнил: Губанова С.О. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Губанова Софья | ИБКСб-24-1                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов,                    *");
            Console.WriteLine("* заполненный статическими значениями в диапазоне от 0 до 9.              *");
            Console.WriteLine("* Подсчитать сумму нечетных элементов массива.                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* {9, 8, 7, 6, 5, 7, 3, 2, 7, 3}                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Сумма нечетных элементов массива равна " + ds.GetSumOddArrEl(array));
            Console.ReadLine();
        }
    }
}
