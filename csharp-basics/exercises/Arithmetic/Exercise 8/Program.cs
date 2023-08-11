namespace Exercise_8;

class Program
{
    static void Main(string[] args)
    {
        alguIzmaksas(8.00, 20);
        alguIzmaksas(7.50, 35);
        alguIzmaksas(8.20, 47);
        alguIzmaksas(10.00, 73);
        alguIzmaksas(8.00, 20);
        alguIzmaksas(8.00, 30);

    }

    static void alguIzmaksas(double stunduLikme, double stundasNostrādātas)
    {
        int stunduDaudzumsGriestiNedēļa = 40;
        double virstunduLikme = stunduLikme * 1.5;

        double alga = 0.0;

        if (stunduLikme < 8)
        {
            Console.WriteLine("Error: The base pay must not be less than the minimum wage ($8.00 an hour)");
            return;
        }

        if (stundasNostrādātas > 60)
        {
            Console.WriteLine("Error: An employee must not work more than 60 hours in a week");
            return;
        }

        if (stundasNostrādātas <= stunduDaudzumsGriestiNedēļa)
        {
            alga = stundasNostrādātas * stunduLikme;
        }

        else if (stundasNostrādātas > stunduDaudzumsGriestiNedēļa)
        {
            alga = stundasNostrādātas * stunduLikme + (stundasNostrādātas * virstunduLikme);
        }


        {
            Console.WriteLine($"Jūsu darba alga ir {alga}");
            Console.ReadLine();
        }
    }

}

