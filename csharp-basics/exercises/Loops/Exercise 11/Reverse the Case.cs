using System;

namespace Exercise_11
{
    class ReversetTheCase
    {
        static void Main(string[] args)
        {
            string[] dotiePiemeri =
            {
                "Happy Birthday",
                "MANY THANKS",
                "SPoNtAnEoUs"
            };

            foreach (var piemeri in dotiePiemeri)
            {
                var apgrieztieZimi = GalaRezultats(piemeri);
                Console.WriteLine($"{piemeri} -> {apgrieztieZimi}");
            }

            Console.ReadKey();
        }

        static string GalaRezultats(string input)
        {
            char[] zimes = input.ToCharArray();
            for (int i = 0; i < zimes.Length; i++)
            {
                if (char.IsUpper(zimes[i]))
                {
                    zimes[i] = char.ToLower(zimes[i]);
                }
                else if (char.IsLower(zimes[i]))
                {
                    zimes[i] = char.ToUpper(zimes[i]);
                }
            }
            return new string(zimes);
        }
    }
}
