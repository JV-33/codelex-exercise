using System;

namespace TenBillion
{
    class Program
    {
        //TODO Write a C# program that reads an positive integer (if it is negative, make it positive) and count the number of digits the number (less than ten billion) has.
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer number less than ten billion: ");

            int input = int.Parse(Console.ReadLine());
            input = Math.Abs(input);

            string skaitluDaudzums = input.ToString();
            int skaitļuSkaits = skaitluDaudzums.Length;



            Console.WriteLine(input);
            Console.WriteLine(skaitļuSkaits);

            Console.ReadKey();
        }
    }
}
