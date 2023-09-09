using System;
namespace VendingMachine.Exeption
{
    public class NegativeProductPriceException : Exception
    {
        public NegativeProductPriceException() { }

        public NegativeProductPriceException(string message)
            : base(message) { }

        public NegativeProductPriceException(string message, Exception inner)
            : base(message, inner) { }
    }
}