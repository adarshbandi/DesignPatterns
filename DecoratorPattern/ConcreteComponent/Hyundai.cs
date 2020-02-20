using System;
using System.Collections.Generic;
using System.Text;
using DecoratorPattern.Component;

namespace DecoratorPattern.ConcreteComponent
{
    public sealed class Hyundai : ICar
    {
        public string Make
        {
            get
            {
                return "Hatchabck";
            }
        }

        public double GetPrice()
        {
            return 800000;
        }
    }
}
