namespace Task1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SavingsAccount : Account
    {
        private double _interestRate;

        public double InterestRate
        {
            get { return _interestRate; }
            set { _interestRate = value; }
        }


        public double CalculateInterest()
        {
            return AccoutBalance * (InterestRate / 100);
        }
    }
}
