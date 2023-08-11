using System;
using System.Linq;

namespace Uzdevums6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ieraksti skaitli");
            string user_input = Console.ReadLine();
            int sum = user_input.Where(char.IsDigit).Sum(c => c - '0');

            Console.WriteLine($"Visu skaitļu summa: {sum}");

            Console.ReadKey();
        }
    }
}
