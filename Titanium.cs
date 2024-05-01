using System;
namespace FactoryDesignPattern
{
    public class Titanium : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 1500;
        }

        public string GetCardType()
        {
            return "Titanium";
        }

        public int GetCreditLimit()
        {
            return 20000;
        }
    }
}
