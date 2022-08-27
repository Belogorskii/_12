using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    static class Rectangle
    {
        static public double GetCircumference(double r)
        {
            return Math.PI * r * r;
        }
        static public double GetSquare(double r)
        {
            return 2.0 * Math.PI * r;
        }
        static public double GetHave(double r, double x0, double y0, double x1, double y1)
        {
            if ((x1 > x0 + r) & (x1 < x0 - r) & (y1 > y0 + r) & (y1 < y0 - r))
                Console.WriteLine("sc");
            else
                Console.WriteLine("snknc");
        }
    }
}