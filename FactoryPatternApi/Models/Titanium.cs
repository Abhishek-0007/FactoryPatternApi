namespace FactoryPatternApi.Models
{
    public class Titanium : CreditCard
    {
        public int CreditCardLimit()
        {
            return 70;
        }

        public string CreditCardType()
        {
            return "Titanium";

        }
    }
}