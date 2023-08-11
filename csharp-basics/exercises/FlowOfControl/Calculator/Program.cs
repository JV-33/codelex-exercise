using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ieraksti skaitli");
            double input;
            while (!double.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Lūdzu ievadiet derīgu skaitli");
            }

            Console.WriteLine("Izvēlies kādu no darbībām");
            Console.WriteLine("1. +");
            Console.WriteLine("2. -");
            Console.WriteLine("3. *");
            Console.WriteLine("4. /");

            var darbiba = Console.ReadLine();

            Console.WriteLine("Ieraksti otru skaitli");
            double input2;
            while (!double.TryParse(Console.ReadLine(), out input2)) 
            {
                Console.WriteLine("Lūdzu ievadiet derīgu skaitli");
            }

            double iznakums = 0;
            switch (darbiba)
            {
                case "1":
                    iznakums = input + input2;
                    break;
                case "2":
                    iznakums = input - input2;
                    break;
                case "3":
                    iznakums = input * input2;
                    break;
                case "4":
                    if (input2 != 0)
                    {
                        iznakums = input / input2;
                    }
                    else
                    {
                        Console.WriteLine("Dalīšana ar 0 nav definēta");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Nezināma darbība");
                    return;
            }

            Console.WriteLine($"Rezultāts ir {iznakums}");
            Console.ReadKey();
        }
    }
}
