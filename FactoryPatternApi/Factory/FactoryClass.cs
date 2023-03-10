using FactoryPatternApi.Models;

namespace FactoryPatternApi.Factory
{
    public static class FactoryClass
    {
        public static CreditCard GetCreditCardInstance(string cardType)
        {
            CreditCard creditCard = null;

            switch(cardType)
            {
                case "Black": 
                    return creditCard = new Black(); 

                case "Platinum":
                    return creditCard = new Platinum(); 

                case "Titanium":
                    return creditCard = new Titanium(); 
            }


            return creditCard;
        }
    }
}
