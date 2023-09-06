using System;
namespace Hierarchy.Exeption
{
	public class UnknownFoodException : Exception
	{
        public UnknownFoodException() : base("Unknown food type provided.")
        {
        }

        public UnknownFoodException(string message) : base(message)
        {
        }
    }
}

