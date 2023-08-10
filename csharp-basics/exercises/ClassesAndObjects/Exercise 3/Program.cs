namespace Exercise_3;

class Program
{
    static void Main(string[] args)
    {
        FuelGauge fuelGauge = new FuelGauge(0);
        Odometer odometer = new Odometer(fuelGauge);

        Console.WriteLine("Fill up your tank... ");

        for (int i = 0; i < 70; i++)
        {
            fuelGauge.AddFuel();
            fuelGauge.ReportCurantAmount();
        }

        Console.WriteLine("\nDriving until we run out of fuel...");

        while (fuelGauge.GetCurrantFuel() > 0)
        {
            odometer.AddMilage();
            odometer.ReportCarMilage();
            fuelGauge.ReportCurantAmount();
        }

        Console.WriteLine("The car has run out of fuel!");


        Console.ReadKey();

    }
}

