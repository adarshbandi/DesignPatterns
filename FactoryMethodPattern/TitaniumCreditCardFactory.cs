using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class TitaniumCreditCardFactory:CreditCardFactory
    {
        private int _creditLimit;
        private int _annualCharge;

        public TitaniumCreditCardFactory(int creditLimit, int anualCharge)
        {
            this._creditLimit = creditLimit;
            this._annualCharge = anualCharge;
        }
        public override CreditCard GetCreditCard()
        {
            return new TitaniumCreditCard(_creditLimit, _annualCharge);
        }
    }
}
