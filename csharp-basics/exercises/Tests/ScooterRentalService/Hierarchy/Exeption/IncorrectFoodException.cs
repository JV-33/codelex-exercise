namespace Hierarchy.Exeption;

	public class IncorrectFoodException : Exception
	{
        public IncorrectFoodException() : base("Incorrect food provided.")
        {
        }
    }