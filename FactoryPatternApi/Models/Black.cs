namespace FactoryPatternApi.Models
{
    public class Black : CreditCard
    {
        public int CreditCardLimit()
        {
            return 25000;
        }

        public string CreditCardType()
        {
            return "Black";

        }
    }
}
