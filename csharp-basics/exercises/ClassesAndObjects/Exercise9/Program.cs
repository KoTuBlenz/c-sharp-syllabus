using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5, 2);
            Point p2 = new Point(-3, 6);
            swapPoints(p1, p2);
            Console.WriteLine("(" + p1.x + ", " + p1.y + ")");
            Console.WriteLine("(" + p2.x + ", " + p2.y + ")");
            Console.ReadKey();
        }

        static void swapPoints(Point point1, Point point2)
        {
            int point1X = point1.x;
            int point1Y = point1.y;
            point1.x = point2.x;
            point1.y = point2.y;
            point2.x = point1X;
            point2.y = point1Y;
        }
    }
}
