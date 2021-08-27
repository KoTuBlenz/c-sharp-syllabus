using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Geometry
    {
        public static double AreaOfCircle(decimal radius)
        {
            return Math.Round(Math.PI * (double)radius * 2, 4);
        }

        public static double AreaOfRectangle(decimal length, decimal width)
        {
            return Math.Round((double)length * (double)width,4);
        }

        public static double AreaOfTriangle(decimal ground, decimal h)
        {
            return Math.Round((double)ground * (double)h * 0.5,4);
        }
    }
}
