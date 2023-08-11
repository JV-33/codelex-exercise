namespace Exercise_9;

class Program
{
    static void Main(string[] args)
    {
        string[] vardi = new string[] { "mavis", "senaida", "letty" };
        string[] rezultats = radietVardus(vardi);
        Console.WriteLine(string.Join(", ", rezultats));

        vardi = new string[] { "samuel", "MABELLE", "letitia", "meridith" };
        rezultats = radietVardus(vardi);
        Console.WriteLine(string.Join(", ", rezultats));



        Console.ReadKey();
    }

    private static string[] radietVardus(string[] vardi)
    {
        return vardi.Select(v => char.ToUpper(v[0]) + v.Substring(1).ToLower()).ToArray();
    }
}

