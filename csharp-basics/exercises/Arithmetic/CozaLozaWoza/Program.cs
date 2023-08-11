using System;

class Program
{
    static void Main(string[] args)
    {
        int līnijuSkaits = 11;
        int kopējaisSkaits = 110;

        for (int i = 1; i <= kopējaisSkaits; i++)
        {
            string izdruka = "";

            if (i % 3 == 0)
            {
                izdruka += "Coza";
            }

            if( i % 5 == 0)
            {
                izdruka += "Loza";
            }

            if (i % 7 == 0)
            {
                izdruka += "Woza";
            }

            if (izdruka == "")
            {
                izdruka = i.ToString();
            }

            Console.Write(izdruka);

            if (i % līnijuSkaits == 0)
            {
                Console.WriteLine();
            }
          
          
            else
            {
                Console.Write(" ");
            }
        }
        Console.ReadKey();
    }
}
