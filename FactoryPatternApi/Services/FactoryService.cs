using FactoryPatternApi.Factory;
using FactoryPatternApi.Models;

namespace FactoryPatternApi.Services
{
    public class FactoryService : IFactoryService
    {
        public CreditCard GetCreditCard(string cardType)
        {
            return FactoryClass.GetCreditCardInstance(cardType);

            //if (cardDetails != null)
            //{
            //    Console.WriteLine("CardType : " + cardDetails.CreditCardType());
            //    Console.WriteLine("CreditLimit : " + cardDetails.CreditCardLimit());
            //}
            //else
            //{
            //    Console.Write("Invalid Card Type");
            //}
            //return cardDetails;
        }
    }
}
