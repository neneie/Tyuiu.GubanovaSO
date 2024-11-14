﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GubanovaSO.Sprint4.Task0.V18.Lib
{
    public class DataService: ISprint4Task0V18
    {
        public int GetSumOddArrEl(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1) sum += array[i];
            }
            return sum;
        }
    }
}
