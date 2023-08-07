namespace Exercise_5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Uzraksti pirmo vārdus!");

        string input = Console.ReadLine();

        Console.WriteLine("Uzraksti otro vārdus!");

        string input1 = Console.ReadLine();

        string result = input;

        int kopaZimes = 30;
        int tagadejaisGarums = result.Length + input1.Length + 1;
        int punktuDaudzums = kopaZimes - tagadejaisGarums;


        for (int i = 0; i < punktuDaudzums; i++)
        {
            result += ".";
        }

        result += input1;

        Console.WriteLine(result);
        Console.ReadKey();
    }
}

