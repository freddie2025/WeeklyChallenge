using System;
using System.Collections.Generic;
using System.Text;

namespace CalculationsLibrary
{
    public static class Calculator
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new ArgumentException("Cannot divide by zero");
            }
            return x / y;
        }

        public static double LimitedAdd(double x, double y, double minValue, double maxValue)
        {
            if (x > maxValue || x < minValue)
            {
                throw new ArgumentOutOfRangeException("x", $"x is outside the specified bounds");
            }

            if (y > maxValue || y < minValue)
            {
                throw new ArgumentOutOfRangeException("y", $"y is outside the specified bounds");
            }

            return x + y;
        }
    }
}
