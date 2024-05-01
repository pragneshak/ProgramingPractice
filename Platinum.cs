using System;
namespace FactoryDesignPattern
{
    public class Platinum : CreditCard
    {
        
        public int GetAnnualCharge()
        {
            return 2000;
        }

        public string GetCardType()
        {
            return "Platinum";
        }

        public int GetCreditLimit()
        {
            return 35000;
        }
    }
}
