using Tyuiu.GubanovaSO.Sprint4.Task3.V30.Lib;

namespace Tyuiu.GubanovaSO.Sprint4.Task3.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[,] nums = { 
                { 2, 4, 3, 5, 1 },
                { 6, 6, 1, 2, 6 },
                { 3, 3, 2, 1, 5 },
                { 6, 4, 1, 3, 3 },
                { 5, 1, 1, 6, 4 } };
            Console.Title = "Спринт #4 | Выполнил: Губанова С.О. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Губанова Софья | ИБКСб-24-1                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,                    *");
            Console.WriteLine("* заполненный статическими значениями в диапазоне от 1 до 6.              *");
            Console.WriteLine("* Найдите максимальный элемент в третьей строке массива.                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* { 2, 4, 3, 5, 1 }                                                       *");
            Console.WriteLine("* { 6, 6, 1, 2, 6 }                                                       *");
            Console.WriteLine("* { 3, 3, 2, 1, 5 }                                                       *");
            Console.WriteLine("* { 6, 4, 1, 3, 3 }                                                       *");
            Console.WriteLine("* { 5, 1, 1, 6, 4 }                                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Максимальный элемент в третьей строке массива равен " + ds.Calculate(nums));
            Console.ReadLine();
        }
    }
}
