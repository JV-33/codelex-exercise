using System;

namespace Exercise3
{
    public class Person
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public int ID { get; set; }

        public Person()
        {
        }

        public Person(string firstName, string lastName, string address, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            ID = id;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Vārds: {FirstName} {LastName}");
            Console.WriteLine($"Adrese: {Address}");
            Console.WriteLine($"ID: {ID}");
        }
    }
}
