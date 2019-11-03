using Augen.TechnicalTest.Domain.Delivery;
using System;

namespace Augen.TechnicalTest.Services
{
    public class MotorbikeDelivery : DeliveryBase
    {
        public override DeliveryServiceTypes ServiceType => DeliveryServiceTypes.Motobike;
        public override double BaseCost => DeliveryServiceConfiguration.MotorbikeBaseCost;
        public override double LowFactor => DeliveryServiceConfiguration.LowMotorbikeFactor;
        public override double HighFactor => DeliveryServiceConfiguration.HighMotorbikeFactor;
        public override double MediumFactor => DeliveryServiceConfiguration.MediumMotorbikeFactor;
    }
}