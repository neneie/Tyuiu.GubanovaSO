﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GubanovaSO.Sprint4.Task5.V12.Lib
{
    public class DataService: ISprint4Task5V12
    {
        public int Calculate(int[,] matrix)
        {
            int c = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0) c++;
                }
            }
            return c;
        }
    }
}
