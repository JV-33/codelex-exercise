namespace Exercise_9;

class RollTwoDice
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ievadi vēlamo metamo kauliņu summu: ");
        int ievaditaSumma = Convert.ToInt32(Console.ReadLine());
       
        bool kauliniVienadi = false;
        Random random = new Random();

        while (!kauliniVienadi )
        {
            
            int pirmaisKaulins = random.Next(1, 7);
            int otraisKaulins = random.Next(1, 7);
            int kaulinuSumma = pirmaisKaulins + otraisKaulins;


            if (ievaditaSumma == kaulinuSumma)
            {
                Console.WriteLine($"{pirmaisKaulins}  + {otraisKaulins} =  {kaulinuSumma}");
                kauliniVienadi = true;
            }

            else
            {
                Console.WriteLine($"{pirmaisKaulins}  + {otraisKaulins} =  {kaulinuSumma}");
            }
        }
        Console.ReadKey();
    }
}

