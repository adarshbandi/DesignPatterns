using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class PlatinumCreditCard : CreditCard
    {
        private readonly string _cardType;
        private int _creditLimit;
        private int _annualCharge;

        public PlatinumCreditCard(int creditLimit, int annualCharge)
        {
            _cardType = "Platinum";
            this._creditLimit = creditLimit;
            this._annualCharge = annualCharge;
        }

        public override string CardType => _cardType;
        public override int CardLimit { get => _creditLimit; set => _creditLimit = value; }
        public override int AnnualCharge { get => _annualCharge; set => _annualCharge = value; }
    }
}
