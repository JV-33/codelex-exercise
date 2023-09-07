using System;

namespace Exercise3
{
    public class Student : Person
    {
        private double _gpa;

        public Student(double gpa)
        {
            _gpa = gpa;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Nav ne jausmas, kas ir : {_gpa}");
        }
    }
}
