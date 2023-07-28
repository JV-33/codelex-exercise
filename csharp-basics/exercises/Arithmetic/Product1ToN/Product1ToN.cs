using System;

namespace Product1ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            int sakums = 1;

            for (int i = 1; i <= 10; i++)
            {
                sakums *= i;
            }

            Console.WriteLine($"Skaitļu reizinājums no 1 līdz 10 ir {sakums}");
        }
    }
}
