using Augen.TechnicalTest.Models;

namespace Augen.TechnicalTest.Services
{
    public class DeliveryCostService : IDeliveryCostService
    {
        public DeliveryCosts GetDeliveryServiceCost()
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
