namespace Exercise_4;

class Program
{
    static void Main(string[] args)
    {
        Movies casinoRojal = new Movies("Casino Royale", "Eon Productions", "PG­13");
        Movies glass = new Movies("Glass", "Buena Vista International", "PG­13");
        Movies spidy = new Movies("Spider-Man: Into the Spider-Verse", "Columbia Pictures", "PG");

        Console.WriteLine($"Title: {casinoRojal.Title}, Studio: {casinoRojal.Studio}, Rating: {casinoRojal.Rating}");
        Console.WriteLine($"Title: {glass.Title}, Studio: {glass.Studio}, Rating: {glass.Rating}");
        Console.WriteLine($"Title: {spidy.Title}, Studio: {spidy.Studio}, Rating: {spidy.Rating}");
        Console.ReadKey();
        
    }
}

