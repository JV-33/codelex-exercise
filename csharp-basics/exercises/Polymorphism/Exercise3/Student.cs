using System;
namespace Exercise3
{
	public class Student : Person
	{
		private double Gpa { get; set; }

		public Student(double gpa)
		{
			Gpa = gpa;
		}

		public override void Display()
		{
			base.Display();
			Console.WriteLine($"Nav ne jausmas, kas ir : {Gpa}");
		}
	}
}

