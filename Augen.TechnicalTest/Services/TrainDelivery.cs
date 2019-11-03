using Augen.TechnicalTest.Domain.Delivery;
using System;

namespace Augen.TechnicalTest.Services
{
    public class TrainDelivery : DeliveryBase
    {
        public override DeliveryServiceTypes ServiceType => DeliveryServiceTypes.Train;
        public override double BaseCost => DeliveryServiceConfiguration.TrainBaseCost;
        public override double LowFactor => DeliveryServiceConfiguration.LowTrainFactor;
        public override double HighFactor => DeliveryServiceConfiguration.HighTrainFactor;
        public override double MediumFactor => DeliveryServiceConfiguration.MediumTrainFactor;
    }
}
