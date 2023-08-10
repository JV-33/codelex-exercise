using System;
namespace FuelConsumptionCalculator
{
	public class Car
	{
         double startKilometers;
         double endKilometers;
         double liters;

        public Car(double startOdo, double endingOdo, double _liters)
        {
            startKilometers = startOdo;
            endKilometers = endingOdo;
            liters = _liters;
        }

        public void FillUp(double mileage, double litersFilled)
        {
            startKilometers = endKilometers;
            endKilometers = mileage;
            liters = litersFilled;
        }

        public double CalculateConsumption()
        {
            double drivenKilometers = endKilometers - startKilometers;
            return (liters / drivenKilometers) * 100; 
        }

        public bool IsGasHog()
        {
            return CalculateConsumption() > 15.0;
        }

        public bool IsEconomyCar()
        {
            return CalculateConsumption() < 5.0;
        }

    }
}

