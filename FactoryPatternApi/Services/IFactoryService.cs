using FactoryPatternApi.Models;

namespace FactoryPatternApi.Services
{
    public interface IFactoryService
    {
        public CreditCard GetCreditCard(string cardType);
    }
}
