using System;
using System.Collections.Generic;
using System.Text;

namespace Studio
{
    class Circle
    {
        public static double GetArea(double radius)
        {
            return System.Math.Pow(radius, 2) * System.Math.PI;
        }

        public static double GetCircum(double radius)
        {
            return 2 * System.Math.PI * radius;
        }

        public static double GetDiameter(double radius)
        {
            return 2 * radius;
        }

        public static double GetGallons(double radius, double mpg)
        {
            return Circle.GetCircum(radius) / mpg;
        }
    }
}
