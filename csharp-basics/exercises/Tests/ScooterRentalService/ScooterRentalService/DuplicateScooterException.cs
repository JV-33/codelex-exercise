using System;
namespace ScooterRentalService
{
	public class DuplicateScooterException : Exception
	{
		public DuplicateScooterException() : base ("Scooter already exists")
		{
		}
	}
}

