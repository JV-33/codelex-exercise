using System;
namespace Exercise3
{
	public class Employee : Person
	{
		public string JobTitle { get; set; }


		public Employee(string jobTitle)
		{
			JobTitle = jobTitle;
		}

		public override void Display()
		{
			base.Display();
			Console.WriteLine($"Strāda par :{JobTitle} ");
		}
	}
}