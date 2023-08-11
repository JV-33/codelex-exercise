using System;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                switch (GetMenu())
                {
                    case 1:
                        CalculateCircleArea();
                        break;
                    case 2:
                        CalculateRectangleArea();
                        break;
                    case 3:
                        CalculateTriangleArea();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Ievadīts nepareizs skaitlis. Lūdzu, ievadi skaitli no 1 līdz 4.");
                        break;



                }
            }
        }

        public static int GetMenu()
        {
            
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
           

            if (int.TryParse(Console.ReadLine(), out int userChoice))
            {
                return userChoice;
            }
            else
            {
                return 0;
            }

                
        }

        public static void CalculateCircleArea()
        {
            
            Console.WriteLine("Kāds ir apļa rādiuss? ");

            if(double.TryParse(Console.ReadLine(), out double radius))
            {
                try
                {
                    Console.WriteLine("The circle's area is "
                    + Geometry.AreaOfCircle(radius));
                }

                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Kļūda: rādiuss nevar būt negatīvs.");
                }

                }
                else
                {
                    Console.WriteLine("Kļūda: nekorekta ievade. Jāievada skaitlis.");
                }

        }






        public static void CalculateRectangleArea()
        {
            Console.WriteLine("Kāds ir taisnstūra garums? ");
            if (!double.TryParse(Console.ReadLine(), out double length))
            {
                Console.WriteLine("Kļūda: nekorekta ievade. Jāievada skaitlis.");
                return;
            }

            Console.WriteLine("Kāds ir taisnstūra platums? ");
            if (!double.TryParse(Console.ReadLine(), out double width))
            {
                Console.WriteLine("Kļūda: nekorekta ievade. Jāievada skaitlis.");
                return;
            }

            try
            {
                Console.WriteLine("The rectangle's area is " + Geometry.AreaOfRectangle(length, width));
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Kļūda: garums un platums nevar būt negatīvi.");
            }
        }

        public static void CalculateTriangleArea()
{
    Console.WriteLine("Kāds ir trijstūra pamats?");
    if(!double.TryParse(Console.ReadLine(), out double ground))
    {
        Console.WriteLine("Kļūda: nekorekta ievade. Jāievada skaitlis.");
        return;
    }

    Console.WriteLine("Kāds ir trijstūra augstums?");
    if(!double.TryParse(Console.ReadLine(), out double height))
    {
        Console.WriteLine("Kļūda: nekorekta ievade. Jāievada skaitlis.");
        return;
    }

    try
    {
        Console.WriteLine("The triangle's area is " + Geometry.AreaOfTriangle(ground, height));
    }
    catch (ArgumentOutOfRangeException)
    {
        Console.WriteLine("Kļūda: pamats un augstums nevar būt negatīvi.");
    }
}

    }
}
