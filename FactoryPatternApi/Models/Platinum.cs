namespace FactoryPatternApi.Models
{
    public class Platinum : CreditCard
    {
        public int CreditCardLimit()
        {
            return 500;   
        }

        public string CreditCardType()
        {
            return "Platinum";

        }
    }
}