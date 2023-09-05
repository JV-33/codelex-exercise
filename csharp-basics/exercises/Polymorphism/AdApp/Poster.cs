using System;
namespace AdApp
{
    public class Poster : Advert
    {
        private int _dimensions;
        private int _numCopies;
        private int _costPerCopy;

        public Poster(int fee, int dimensions, int numCopies, int costPerCopy) : base(fee)
        {
            _dimensions = dimensions;
            _numCopies = numCopies;
            _costPerCopy = costPerCopy;
        }

        public override int Cost()
        {
            return base.Cost() + (_numCopies * _costPerCopy);
        }
    }
}

