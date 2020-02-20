using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public class MoneyBackCreditCardFactory : CreditCardFactory
    {
        private int _creditLimit;
        private int _annualCharge;

        public MoneyBackCreditCardFactory(int creditLimit, int anualCharge)
        {
            this._creditLimit = creditLimit;
            this._annualCharge = anualCharge;
        }
        public override CreditCard GetCreditCard()
        {
            return new MoneyBackCreditCard(_creditLimit, _annualCharge);
        }
    }
}
