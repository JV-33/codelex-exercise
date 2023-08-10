using System;
namespace Exercise_3
{
	public class FuelGauge
	{
		private int _currentFuel; 
		private const int _fullTank = 70;

		public FuelGauge(int startFuel)
		{
			_currentFuel =startFuel <= _fullTank ? startFuel : _fullTank  ;
		}

		public int GetCurrantFuel()
		{
			return _currentFuel; 
		}

		public void ReportCurantAmount()
		{
			Console.WriteLine($"Car's current amount of fuel: {_currentFuel} liters");
		}

		public void AddFuel()
		{
			if (_currentFuel < _fullTank)
			{
                _currentFuel++;
            }
		
		}

		public void CutFuel()
		{
			if (_currentFuel > 0)
			{
                _currentFuel--;
            }
			
		}
	}
}

