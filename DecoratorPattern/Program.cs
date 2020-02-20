using System;
using DecoratorPattern.Component;
using DecoratorPattern.ConcreteComponent;
using DecoratorPattern.ConcreteDecorator;
using DecoratorPattern.Decorator;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar car = new Suzuki();
            CarDecorator decorator = new OfferPrice(car);

            Console.WriteLine($"Make: {car.Make} Price: {car.GetPrice().ToString()} " +
                $"DiscountedPrice: {decorator.GetDiscountedPrice().ToString()}");
        }
    }
}
