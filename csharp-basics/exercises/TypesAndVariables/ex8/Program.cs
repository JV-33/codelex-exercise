namespace ex8;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pārvērt minūtes skaiļos par gadu un dienām ");
        string userInput = Console.ReadLine();

        if (long.TryParse(userInput, out long minūtes))
        {
            const int MinutesInYear = 525600;
            const int MinutesInDay = 1440;

            long years = minūtes / MinutesInYear;
            minūtes %= MinutesInYear;

            long days = minūtes / MinutesInDay;

            Console.WriteLine($"{userInput} minūtes ir apmēram {years} gadi un {days} dienas.");
        }
        else
        {
            Console.WriteLine("Nederīgs lietotāja ievads!!! Ievadiet skaitli");
        }
        Console.ReadKey();
    }
}
