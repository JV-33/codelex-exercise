namespace Firm
{
    public class Commission : Hourly
    {
        private double _totalSales;
        private double _commissionRate;

        public Commission(string eName, string eAddress, string ePhone,
                          string socSecNumber, double rate, double commissionRate)
            : base(eName, eAddress, ePhone, socSecNumber, rate)
        {
            _commissionRate = commissionRate;
            _totalSales = 0;
        }

        public void AddSales(double totalSales)
        {
            _totalSales += totalSales;
        }

        public override double Pay()
        {
            double payment = base.Pay() + (_commissionRate * _totalSales);
            _totalSales = 0;  
            return payment;
        }

        public override string ToString()
        {
            return base.ToString() + "\nTotal Sales: " + _totalSales;
        }
    }
}
