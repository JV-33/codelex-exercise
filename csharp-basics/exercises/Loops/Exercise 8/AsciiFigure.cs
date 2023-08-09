using System;

namespace Exercise_8
{
    class AsciiFigure
    {
        static readonly int Izmers = 7;  

        static void Main(string[] args)
        {
            int kopejaiasPlatums = Izmers * 8 - 10 ; 

           
            for (int i = 0; i < Izmers - 1; i++)
            {
                for (int j = 0; j < kopejaiasPlatums / 2 - 4 * i; j++)
                    Console.Write("/");
                for (int k = 0; k < 8 * i; k++)
                    Console.Write("*");
                for (int l = 0; l < kopejaiasPlatums / 2 - 4 * i; l++)
                    Console.Write("\\");
                Console.WriteLine();
            }

           
            for (int m = 0; m < kopejaiasPlatums; m++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
