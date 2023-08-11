using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Geometry
    {
        public static double AreaOfCircle(double radius)
        {
            if (radius < 0)
            {
                Console.WriteLine("Error: Rādius nevar būt negatīvs.");
                throw new ArgumentOutOfRangeException(" Rādius nevar būt negatīvs!!!");
            }
           
            return Math.PI * radius * radius; 
        }

        public static double AreaOfRectangle(double length, double width)
        {
            if(length< 0 || width < 0)
            {
                Console.WriteLine("Error: Garums un platums nevar būt negatīvi.");
                throw new ArgumentOutOfRangeException("Garums un platums nevar būt negatīvi!!!");
            }
            return length * width;
        }

        public static double AreaOfTriangle(double ground, double h)
        {
            if(ground < 0 || h < 0)
            {
                Console.WriteLine("Error: Pamats un augstums nevar būt negatīvi.");
                throw new ArgumentOutOfRangeException("Pamats un augstums nevar būt negatīvi!!!");
            }
            return ground * h * 0.5; 
        }
    }
}
