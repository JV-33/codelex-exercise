namespace AdApp
{
    public class NewspaperAd : Advert
    {
        private int _columnCm;
        private int _ratePerColumnCm;

        public NewspaperAd(int fee, int columnCm, int ratePerColumnCm) : base(fee)
        {
            _columnCm = columnCm;
            _ratePerColumnCm = ratePerColumnCm;
        }

        public override int Cost()
        {
            return base.Cost() + (_columnCm * _ratePerColumnCm);
        }
    }
}
