using System;
using System.Collections.Generic;
using System.Text;
using DecoratorPattern.Component;

namespace DecoratorPattern.ConcreteComponent
{
    public sealed class Suzuki : ICar
    {
        public string Make
        {
            get
            {
                return "Sedan";
            }
        }

        public double GetPrice()
        {
            return 600000;
        }
    }
}
