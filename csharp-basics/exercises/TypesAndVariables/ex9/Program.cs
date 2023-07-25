namespace ex9;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ievadiet distanci metros");
        double distanceMetros = double.Parse(Console.ReadLine());

        Console.WriteLine("Ievadiet stundas");
        double laiksStundās = double.Parse(Console.ReadLine());

        Console.WriteLine("Ievadiet minūtes");
        double laiksMinutēs = double.Parse(Console.ReadLine());

        Console.WriteLine("Ievadiet sekundes");
        double laiksSekundēs = double.Parse(Console.ReadLine());

        // Pārveidot visu laiku sekundēs
        double totalTimeSeconds = (laiksStundās * 3600) + (laiksMinutēs * 60) + laiksSekundēs;

        // Aprēķināt ātrumu metri/sekundē
        double speedMps = distanceMetros / totalTimeSeconds;

        // Aprēķināt ātrumu km/stundā
        double speedKmph = (distanceMetros / 1000) / (totalTimeSeconds / 3600);

        // Aprēķināt ātrumu jūdzes/stundā (1 jūdze ir apmēram 1609.34 metri)
        double speedMph = (distanceMetros / 1609.34) / (totalTimeSeconds / 3600);



        Console.WriteLine($"Jūsu ātrums metri/sekundē ir {Math.Round(speedMps, 8)}");
        Console.WriteLine($"Jūsu ātrums km/stundā ir {Math.Round(speedKmph, 8)}");
        Console.WriteLine($"Jūsu ātrums jūdzes/stundā ir {Math.Round(speedMph ,8)}");



        Console.ReadKey();
    }
}

