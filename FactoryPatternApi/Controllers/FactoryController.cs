using FactoryPatternApi.Models;
using FactoryPatternApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace FactoryPatternApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FactoryController : ControllerBase
    {
        private readonly IFactoryService _service;
        public FactoryController(IServiceProvider serviceProvider)
        {
            _service = serviceProvider.GetRequiredService<IFactoryService>();    
        }

        [HttpGet]
        public string GetCreditCard(string cardType)
        {
            var obj = _service.GetCreditCard(cardType);

            return $"Credit Card Type = {obj.CreditCardType() } \nCredit Card Limit = {obj.CreditCardLimit()}";
        }
    }
}
