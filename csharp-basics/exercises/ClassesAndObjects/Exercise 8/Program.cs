using System;
using System.Drawing;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5, 2);
            Point p2 = new Point(-3, 6);
            (p1, p2) = SwapPoints(p1, p2);
            Console.WriteLine("(" + p1.X + ", " + p1.Y + ")");
            Console.WriteLine("(" + p2.X + ", " + p2.Y + ")");

            Console.ReadKey();
        }

        static (Point, Point) SwapPoints(Point p1, Point p2)
        {
            return (p2, p1);
        }
    }
}
