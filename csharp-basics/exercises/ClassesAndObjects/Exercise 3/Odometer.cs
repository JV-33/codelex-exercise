using System;
namespace Exercise_3
{
	public class Odometer
	{
		private int _currentMilage; 
		private double _maxMilage = 999999;
		private int _decreaseAmount = 10;
        private FuelGauge _fuelGauge;

        public Odometer(FuelGauge fuelGauge)
		{
			_currentMilage = 0;
			_fuelGauge = fuelGauge;
		}

		public int CarsMilage()
		{
			return _currentMilage; 
		}

		public void ReportCarMilage()
		{
            Console.WriteLine($"Car's current mileage: {_currentMilage} kilometers");

        }

        public void AddMilage()
		{
			if ( _currentMilage < _maxMilage)
			{
				_currentMilage++;
			}
			else 
			{
				_currentMilage = 0; 
			}
            CutMilage();
        }

		public void CutMilage()
		{
			if (_currentMilage % _decreaseAmount == 0)
			{
				_fuelGauge.CutFuel();
			}
		}
	}
}

