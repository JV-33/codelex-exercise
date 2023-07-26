namespace Product1ToN;

class Program
{
    static void Main(string[] args)
    {
        int sākums = 1;
        

        

        for (int i = 1; i <= 10; i++)
        {
            sākums *= i;
        }

        Console.WriteLine($"Skaitļu reizinājums no 1 līdz 10 ir {sākums}");
    }
}

