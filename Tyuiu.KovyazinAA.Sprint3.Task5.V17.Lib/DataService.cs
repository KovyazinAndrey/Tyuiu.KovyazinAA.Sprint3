﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KovyazinAA.Sprint3.Task5.V17.Lib
{
    public class DataService : ISprint3Task5V17
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sum = 0;
            int i, j;
            for (i = startValue1; i <= stopValue1; i++)
            { 
                for (j = startValue2; j <= stopValue2; j++)
                {
                    sum = sum + (Math.Sin(j) + Math.Pow(x, 2));
                }
            }
            return Math.Round(sum,3);
        }
    }
}
