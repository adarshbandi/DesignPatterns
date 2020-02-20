using System;
using System.Collections.Generic;
using System.Text;
using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

namespace DecoratorPattern.ConcreteDecorator
{
    public class OfferPrice : CarDecorator
    {
        public OfferPrice(ICar car) : base(car)
        {
        }

        public override double GetDiscountedPrice()
        {
            return 0.8 * base.GetPrice();
        }
    }
}
