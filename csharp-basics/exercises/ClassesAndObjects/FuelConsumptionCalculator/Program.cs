using System;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter the starting odometer reading for Car1:");
            double startOdo1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the ending odometer reading for Car1:");
            double endingOdo1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the liters used by Car1:");
            double liters1 = Convert.ToDouble(Console.ReadLine());

            Car car1 = new Car(startOdo1, endingOdo1, liters1);

            Console.WriteLine("Enter the starting odometer reading for Car2:");
            double startOdo2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the ending odometer reading for Car2:");
            double endingOdo2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the liters used by Car2:");
            double liters2 = Convert.ToDouble(Console.ReadLine());

            Car car2 = new Car(startOdo2, endingOdo2, liters2);

            DisplayCarDetails(car1, "Car1");
            DisplayCarDetails(car2, "Car2");

            Console.WriteLine("Fill up Car1");
            Console.WriteLine("Enter the mileage for Car1:");
            double mileage1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the liters filled for Car1:");
            double litersFilled1 = Convert.ToDouble(Console.ReadLine());
            car1.FillUp(mileage1, litersFilled1);

            DisplayCarDetails(car1, "Car1");

            Console.WriteLine("Fill up Car2");
            Console.WriteLine("Enter the mileage for Car2:");
            double mileage2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the liters filled for Car2:");
            double litersFilled2 = Convert.ToDouble(Console.ReadLine());
            car2.FillUp(mileage2, litersFilled2);

            DisplayCarDetails(car2, "Car2");
        }

        private static void DisplayCarDetails(Car car, string carName)
        {
            Console.WriteLine($"{carName} Consumption: {car.CalculateConsumption()} L/100km");
            if (car.IsGasHog())
            {
                Console.WriteLine($"{carName} is a Gas Hog.");
            }
            if (car.IsEconomyCar())
            {
                Console.WriteLine($"{carName} is an Economy Car.");
            }
            Console.WriteLine();
        }
    }
}
