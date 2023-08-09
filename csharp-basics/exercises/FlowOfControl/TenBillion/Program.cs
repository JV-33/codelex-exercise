using System;

namespace TenBillion
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer number less than ten billion: ");

            long input = long.Parse(Console.ReadLine());
            input = Math.Abs(input);

            string skaitluDaudzums = input.ToString();
            int skaitļuSkaits = skaitluDaudzums.Length;

            Console.WriteLine(input);
            Console.WriteLine(skaitļuSkaits);

            Console.ReadKey();
        }
    }
}
