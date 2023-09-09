namespace Exercise_6;

class Program
{
    static void Main(string[] args)
    {
        int [] raditaisMasivs = new int[10];
        Random random = new Random();

        for (int i = 0; i < raditaisMasivs.Length; i++)
        {
            raditaisMasivs[i] = random.Next(1, 101);
        }
        int[] kopetaisMasivs = new int[10];
        Array.Copy(raditaisMasivs, kopetaisMasivs, raditaisMasivs.Length);

        raditaisMasivs[raditaisMasivs.Length - 1] = -7;

        Console.Write("raditaisMasivs: ");
        for (int i = 0; i < raditaisMasivs.Length; i++)
        {
            Console.Write(raditaisMasivs[i] + " ");
        }

        Console.WriteLine();

        Console.Write("kopetaisMasivs: ");
        for (int i = 0; i < kopetaisMasivs.Length; i++)
        {
            Console.Write(kopetaisMasivs[i] + " ");
        }
       






        Console.ReadKey();
    }
}

