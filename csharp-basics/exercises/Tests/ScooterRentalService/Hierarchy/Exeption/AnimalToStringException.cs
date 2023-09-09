using System;
namespace Hierarchy.Exeption
{
    public class AnimalToStringException : Exception
    {
        public AnimalToStringException() : base() { }
        public AnimalToStringException(string message) : base(message) { }
        public AnimalToStringException(string message, Exception innerException) : base(message, innerException) { }
    }
}

