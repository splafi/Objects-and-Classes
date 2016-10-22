using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Closest_Two_Points
{
    class ClosestTwoPoints
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Point[] points = new Point[n];
            for (int i = 0; i < n; i++)
            {
                points[i] = ReadPoint();
            }
            Point[] closesPoints = FindClosestTwoPoints(points);
            double dist = CalcDist(closesPoints[0], closesPoints[1]);
            PrintDistance(closesPoints);
            PrintPoint(closesPoints[0]);
            PrintPoint(closesPoints[1]);

        }

        static double CalcDist(Point p1, Point p2)
        {
            double a = Math.Abs(p1.X - p2.X);
            double b = Math.Abs(p1.Y - p2.Y);
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
        static Point[] FindClosestTwoPoints(Point[] points)
        {
            double minDistance = double.MaxValue;
            Point[] closestTwoPoints = null;
            for (int p1 = 0; p1 < points.Length; p1++)
                for (int p2 = p1 + 1; p2 < points.Length; p2++)
                {
                    double distance = CalcDist(points[p1], points[p2]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestTwoPoints = new Point[] { points[p1], points[p2] };
                    }
                }
            return closestTwoPoints;
        }
        static void PrintPoint(Point point)
        {
            Console.WriteLine("({0}, {1})", point.X, point.Y);
        }
        static void PrintDistance(Point[] points)
        {
            double distance = CalcDist(points[0], points[1]);
            Console.WriteLine("{0:f3}", distance);
}


    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
