namespace Exercise_9;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lūdzu ievadiet savu augumu metros:");
        double augums = double.Parse(Console.ReadLine());
        Console.Write("Ievadīet savu svaru kilogramos:");
        double svars = double.Parse(Console.ReadLine());

        double augumsColās = augums * 39.3701;
        double svarsMārciņās = svars * 2.20462;

        double aprēķins = svars * 703 / (augumsColās * augumsColās);

        if(aprēķins < 18.5)
        {
            Console.WriteLine("Tev ir par mazs svara!!");
        }

        if(aprēķins > 25)
        {
            Console.WriteLine("Tu esi par resnu");
        }

        if(aprēķins > 18.5 && aprēķins <=25)
        {
            Console.WriteLine("Tev itkā esot tāds svars kā vajag");
        }





        Console.WriteLine($"Tava ķermeņa BMI ir {aprēķins}");
        Console.ReadKey();
    }
}

