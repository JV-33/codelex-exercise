namespace Exerco;

class Program
{
    static void Main(string[] args)
    {
        
        Random random = new Random();
        int[] skaitli = new int[20];

        for (int i = 0; i < 20; i++)
        {
            skaitli[i] = random.Next(1, 101);
        }


        Console.WriteLine("Tev ģenerētie skaitļi ir : ");
        for (int i = 0; i < skaitli.Length; i++)
        {
            Console.Write(skaitli[i] + " ");
        }


        Console.WriteLine();
        Console.WriteLine("Izvēlies vienu no 20 skaitļiem, lai uzzinātu tā pozīciju :");
        int input = Convert.ToInt32(Console.ReadLine());

        int pozicija = Array.IndexOf(skaitli, input) + 1;

        Console.WriteLine(pozicija);


        Console.ReadKey();
    }
}

