using System;

namespace Exercise_9
{
    class RollTwoDice
    {
        static void Main(string[] args)
        {
            Console.Write("Desired sum: ");
            int ievaditaSumma = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();

            while (true)
            {
                int pirmaisKaulins = random.Next(1, 7);
                int otraisKaulins = random.Next(1, 7);
                int kaulinuSumma = pirmaisKaulins + otraisKaulins;

                Console.WriteLine($"{pirmaisKaulins} and {otraisKaulins} = {kaulinuSumma}");

                if (ievaditaSumma == kaulinuSumma)
                {
                    break;  // Apstādināt ciklu
                }
            }

            Console.ReadKey();
        }
    }
}
