namespace Exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] skaitli = new int[][]
            {
                new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15},
                new int[] {92, 6, 73, -77, 81, -90, 99, 8, -85, 34},
                new int[] {91, -4, 80, -73, -28},
                new int[] {}
            };

            foreach (int[] skaitlisMasiva in skaitli)
            {
                int[] izmainitsMasivs = JaunsMasivs(skaitlisMasiva);

                foreach (int i in izmainitsMasivs)
                {
                    Console.Write(i);
                }
            }

            Console.ReadKey();
        }

        private static int[] JaunsMasivs(int[] skaitlis)
        {
            int pozitivieSkaitli = 0;
            int negativoSumma = 0;

            for (int i = 0; i < skaitlis.Length; i++)
            {
                if (skaitlis[i] > 0)
                    pozitivieSkaitli += 1;
                else if (skaitlis[i] < 0)
                    negativoSumma += skaitlis[i];
            }

            if (skaitlis.Length == 0)
            {
                return new int[] { };
            }
            return new int[] { pozitivieSkaitli, negativoSumma };
        }
    }
}
