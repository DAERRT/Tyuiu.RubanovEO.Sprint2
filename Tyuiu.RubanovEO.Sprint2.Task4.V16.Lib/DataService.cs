﻿
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.RubanovEO.Sprint2.Task4.V16.Lib
{
    public class DataService : ISprint2Task4V16
    {
        public double Calculate(double x, double y)
        {
            double z = (x * 2) < (y * 2) ? Math.Pow(1 + (1 / Math.Pow(y, 2)), x) : (y - (1 / Math.Pow(x, 2)));
            return Math.Round(z, 3);
        }
    }
}
