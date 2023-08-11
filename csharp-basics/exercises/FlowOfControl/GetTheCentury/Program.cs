using System;

namespace GetTheCentury
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uzraskti gadu : ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(Century(input));
            Console.ReadKey();
        }

        static string Century(int years)
        {
            int century = years / 100;
            if (years % 100 != 0)
            {
                century++;
            }
            return $"{century}{Gadsimts(century)} century";
        }

        static string Gadsimts(int century)
        {
            switch (century % 100)
            {
                case 11:
                case 12:
                case 13:
                    return "th";
                default:
                    switch (century % 10)
                    {
                        case 1:
                            return "st";
                        case 2:
                            return "nd";
                        case 3:
                            return "rd";
                        default:
                            return "th";
                    }
            }
        }
    }
}

