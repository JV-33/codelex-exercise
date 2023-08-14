namespace Exercise_14;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Date.GetCurantData(1970, 9, 21));
        Console.WriteLine(Date.GetCurantData(1945, 9, 2));   
        Console.WriteLine(Date.GetCurantData(2001, 9, 11));
        Console.ReadKey();
    }
}

