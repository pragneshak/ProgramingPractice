using System;
namespace FactoryDesignPattern
{
    public class CreditCardfactory
    {
        public static CreditCard GetCreditCard(string cardType) {
            CreditCard cardDetails = null;
            //Based of the CreditCard Type we are creating the
            //appropriate type instance using if else condition
            if (cardType == "MoneyBack")
                {
                    cardDetails = new MoneyBack();
                  }
                else if (cardType == "Titanium")
                {
                    cardDetails = new Titanium();
                }
                else if (cardType == "Platinum")
                    {
                        cardDetails = new Platinum();
                    }
                return cardDetails;
}
        
    }
}
