using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public abstract class CreditCardFactory
    {
        public abstract CreditCard GetCreditCard();
    }
}
