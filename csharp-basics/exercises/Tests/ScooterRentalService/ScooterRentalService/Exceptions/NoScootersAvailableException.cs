using System;
namespace ScooterRentalService
{
	public class NoScootersAvailableException :Exception
	{
		public NoScootersAvailableException() :base (" No scooters availab")
		{
		}
	}
}

