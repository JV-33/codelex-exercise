using System;

namespace Exercise4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            foreach (var item in vowels)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < vowels.Length; i++)
            {
                Console.WriteLine(vowels[i]);
            }

            Console.ReadKey();

           

            

        }
    }
}
