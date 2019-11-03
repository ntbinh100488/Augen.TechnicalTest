using Augen.TechnicalTest.Models;
using Augen.TechnicalTest.Services;
using Microsoft.AspNetCore.Mvc;

namespace Augen.TechnicalTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryController : ControllerBase
    {
        // GET: api/Delivery
        [HttpGet]
        public DeliveryCosts GetDeliveryCost()
        {
            var deliveryCost = new DeliveryCosts();

            // motorbike
            DeliveryFactory factory = new MotorbikeDeliveryFactory();
            deliveryCost.Motorbike = factory.GetDelivery().GetDeliveryCost();

            // train
            factory = new TrainDeliveryFactory();
            deliveryCost.Train = factory.GetDelivery().GetDeliveryCost();

            // aircraft
            factory = new AircraftDeliveryFactory();
            deliveryCost.Aircraft = factory.GetDelivery().GetDeliveryCost();

            return deliveryCost;
        }
    }
}