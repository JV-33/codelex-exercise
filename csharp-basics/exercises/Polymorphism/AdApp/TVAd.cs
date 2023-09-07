namespace AdApp
{
    public class TVAd : Advert
    {
        private int _seconds;
        private int _ratePerSecond;
        private bool _peakTime;

        public TVAd(int fee, int seconds, int ratePerSecond, bool peakTime) : base(fee)
        {
            _seconds = seconds;
            _ratePerSecond = ratePerSecond;
            _peakTime = peakTime;
        }

        public override int Cost()
        {
            int cost = _seconds * _ratePerSecond;
            if (_peakTime)
            {
                cost *= 2;
            }
            return base.Cost() + cost;
        }
    }
}
