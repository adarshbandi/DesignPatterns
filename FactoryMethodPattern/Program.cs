using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCardFactory factory = null;
            Console.WriteLine("Please select your card type");
            string cardType = Console.ReadLine();

            switch (cardType.ToLower())
            {
                case "moneyback":
                    factory= new MoneyBackCreditCardFactory(50000, 500);
                    break;
                case "platinum":
                    factory = new PlatinumCreditCardFactory(100000, 100);
                    break;
                case "titanium":
                    factory = new TitaniumCreditCardFactory(200000, 0);
                    break;
                default:
                    break;
            }

            CreditCard creditCard = factory.GetCreditCard();
            Console.WriteLine("Know your card: ");

            Console.WriteLine($"Card Type: {creditCard.CardType}, Credit Limit: {creditCard.CardLimit}, Annual Charge: {creditCard.AnnualCharge}"); 
        }
    }
}
