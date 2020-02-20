using System;
using System.Collections.Generic;
using System.Text;
using DecoratorPattern.Component;

namespace DecoratorPattern.Decorator
{
    public abstract class CarDecorator : ICar
    {
        private ICar _car;
        public CarDecorator(ICar car)
        {
            this._car = car;
        }

        public string Make
        {
            get
            {
                return _car.Make;
            }
        }

        public double GetPrice()
        {
            return _car.GetPrice();
        }

        public abstract double GetDiscountedPrice();
    }
}
