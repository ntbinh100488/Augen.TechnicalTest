using Augen.TechnicalTest.Models;
using Augen.TechnicalTest.Services;
using Microsoft.AspNetCore.Mvc;

namespace Augen.TechnicalTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryController : ControllerBase
    {
        private readonly IDeliveryCostService _deliveryCostService;
        public DeliveryController(IDeliveryCostService deliveryCostService)
        {
            _deliveryCostService = deliveryCostService;
        }

        // GET: api/Delivery
        [HttpGet]
        public DeliveryCosts GetDeliveryCost()
        {
            return _deliveryCostService.GetDeliveryServiceCost();
        }
    }
}