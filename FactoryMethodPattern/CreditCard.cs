using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public abstract class CreditCard
    {
        public abstract string CardType { get; }
        public abstract int CardLimit { get; set; }
        public abstract int AnnualCharge { get; set; }
    }
}
