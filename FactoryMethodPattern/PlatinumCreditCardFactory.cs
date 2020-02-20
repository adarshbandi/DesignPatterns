using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class PlatinumCreditCardFactory:CreditCardFactory
    {
        private int _creditLimit;
        private int _annualCharge;

        public PlatinumCreditCardFactory(int creditLimit, int anualCharge)
        {
            this._creditLimit = creditLimit;
            this._annualCharge = anualCharge;
        }
        public override CreditCard GetCreditCard()
        {
            return new PlatinumCreditCard(_creditLimit, _annualCharge);
        }
    }
}
