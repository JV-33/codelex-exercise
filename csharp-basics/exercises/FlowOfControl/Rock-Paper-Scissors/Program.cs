using System;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Izvēlies iespēju:");
            Console.WriteLine("1. Akmens");
            Console.WriteLine("2. Šķēres");
            Console.WriteLine("3. Papīrs");

            string inputString = Console.ReadLine();
            int input;

            while (!int.TryParse(inputString, out input) || input < 1 || input > 3)
            {
                Console.WriteLine("Lūdzu, ievadiet derīgu skaitli no 1 līdz 3.");
                inputString = Console.ReadLine();
            }

            int datoraIzvele = rnd.Next(1, 4);

            if (input == datoraIzvele)
            {
                Console.WriteLine("Neizšķirts!");
            }

            else if ((input == 1 && datoraIzvele == 2) ||
                     (input == 2 && datoraIzvele == 3) ||
                     (input == 3 && datoraIzvele == 1))
            {
                Console.WriteLine("Tu uzvarēji");
            }

            else
            {
                Console.WriteLine("Dators uzvarēja");
            }
            string[] izvelesIespejas = new string[] { "Akmens", "Šķēres", "Papīrs" };
            Console.WriteLine($"Tava izvēle bija {izvelesIespejas[input - 1]} ,datora izvēle {izvelesIespejas[datoraIzvele - 1]}");
            Console.ReadKey();
        }
    }
}
