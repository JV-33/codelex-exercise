namespace AdApp
{
    public class Hoarding : Advert
    {
        private bool _primeLocation;
        private int _numDays;
        private int _standardCost;

        public Hoarding(int fee, int numDays, int standardCost, bool primeLocation) : base(fee)
        {
            _numDays = numDays;
            _standardCost = standardCost;
            _primeLocation = primeLocation;
        }

        public override int Cost()
        {
            int cost = _standardCost * _numDays;
            if (_primeLocation)
            {
                cost += (int)(cost * 0.5); 
            }
            return base.Cost() + cost;
        }
    }
}