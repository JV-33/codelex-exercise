using AdApp;
using System;

class Program
{
    private static void Main(string[] args)
    {
        var c = new Campaign();
        c.AddAdvert(new Advert(1000));
        c.AddAdvert(new Hoarding(500, 7, 200, false));  
        c.AddAdvert(new NewspaperAd(0, 30, 20));  
        c.AddAdvert(new TVAd(50000, 30, 1000, true));
        Console.WriteLine(c);
        Console.ReadKey();
    }
}
