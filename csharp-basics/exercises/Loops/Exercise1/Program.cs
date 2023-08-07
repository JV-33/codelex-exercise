using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0  ;

            Console.WriteLine("The first 10 natural numbers are: ");
            
            for ( i = 0; i < 11; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
