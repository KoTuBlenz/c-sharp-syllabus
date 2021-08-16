using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5, 2);
            Point p2 = new Point(-3, 6);
            swapPoints(p1, p2);
            Console.WriteLine("(" + p1.X + ", " + p1.Y + ")");
            Console.WriteLine("(" + p2.X + ", " + p2.Y + ")");
            Console.ReadKey();
        }

        static void swapPoints(Point point1, Point point2)
        {
            int point1X = point1.X;
            int point1Y = point1.Y;
            point1.X = point2.X;
            point1.Y = point2.Y;
            point2.X = point1X;
            point2.Y = point1Y;
        }
    }
}
