using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Pract12
{
    static class CircleHelper
    {
        public static double CalculateCircumference(double radius)
        {
            return 2 * Math.PI * radius;
        }

        public static double CalculateArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public static bool IsPointInsideCircle(double x, double y, double x0, double y0, double radius)
        {
            double distance = Math.Sqrt(Math.Pow(x - x0, 2) + Math.Pow(y - y0, 2));
            return distance <= radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double radius = 5;
            double x0 = 0;
            double y0 = 0;

            Console.WriteLine("Длина окружности с радиусом {0}: {1}", radius, CircleHelper.CalculateCircumference(radius));
            Console.WriteLine("Площадь круга с радиусом {0}: {1}", radius, CircleHelper.CalculateArea(radius));

            double x = 3;
            double y = 4;
            bool isInside = CircleHelper.IsPointInsideCircle(x, y, x0, y0, radius);
            Console.WriteLine("Точка ({0},{1}) принадлежит окружности с радиусом {2} и центром в точке ({3},{4}): {5}", x, y, radius, x0, y0, isInside);
        }
    }
}