using Tyuiu.GubanovaSO.Sprint4.Task2.V25.Lib;

namespace Tyuiu.GubanovaSO.Sprint4.Task2.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();
            Console.Title = "Спринт #4 | Выполнил: Губанова С.О. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Губанова Софья | ИБКСб-24-1                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 11 элементов,                    *");
            Console.WriteLine("* заполненный случайными значениями в диапазоне от 3 до 9.                *");
            Console.WriteLine("* Подсчитать произведение четных элементов массива.                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Сгенерированный массив: ");
            int[] array = new int[11];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(3, 10);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Проьизведение элементов массива равно " + ds.Calculate(array));
            Console.ReadLine();
        }
    }
}
