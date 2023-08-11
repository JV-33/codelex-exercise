using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Zed A. Shaw";
            string eyes = "Blue";
            string teeth = "White";
            string hair = "Brown";
            int age = 35;
            int heightInInches = 74;  // inches
            int weightInPounds = 180; // lbs


            double heightInCm = Math.Round(ConvertToCentimeters(heightInInches),2);
            double weightInKg = Math.Round(ConvertToKilograms(weightInPounds),2);

            Console.WriteLine("Let's talk about " + name + ".");
            Console.WriteLine("He's " + heightInCm + " inches tall.");
            Console.WriteLine("He's " + weightInKg + " pounds heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + eyes + " eyes and " + hair + " hair.");
            Console.WriteLine("His teeth are usually " + teeth + " depending on the coffee.");

            Console.WriteLine("If I add " + age + ", " + heightInCm + ", and " + weightInKg
                               + " I get " + (age + heightInCm + weightInKg) + ".");

            Console.ReadKey();
        }

        static double ConvertToCentimeters(double inches)
        {
            return inches * 2.54;
        }

        static double ConvertToKilograms(double pounds)
        {
            return pounds * 0.453592;
        }
    }
}