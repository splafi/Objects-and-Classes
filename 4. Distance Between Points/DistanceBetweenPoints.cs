using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Distance_Between_Points
{
    class DistanceBetweenPoints
    {
        static void Main(string[] args)
        {
            Point p1 = ReadPoint();
            Point p2 = ReadPoint();
            Console.WriteLine("{0:f3}",CalcDist(p1,p2));
        }
        static double CalcDist(Point p1, Point p2)
        {
            double a = Math.Abs(p1.X-p2.X);
            double b = Math.Abs(p1.Y-p2.Y);
            return Math.Sqrt(a * a + b * b);
        }
        static Point ReadPoint()
        {
            int[] pointinfo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Point point = new Point();
            point.X = pointinfo[0];
            point.Y = pointinfo[1];
            return point;
        }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

}
