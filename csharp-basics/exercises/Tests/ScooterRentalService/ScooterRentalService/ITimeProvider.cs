using System;
namespace ScooterRentalService
{
	public interface ITimeProvider
	{
        DateTime Now { get; }
    }
}

