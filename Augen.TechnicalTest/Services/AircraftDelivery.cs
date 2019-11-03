using Augen.TechnicalTest.Domain.Delivery;
using System;

namespace Augen.TechnicalTest.Services
{
    public class AircraftDelivery : DeliveryBase
    {
        public override DeliveryServiceTypes ServiceType => DeliveryServiceTypes.Aircraft;
        public override double BaseCost => DeliveryServiceConfiguration.AircraftBaseCost;
        public override double LowFactor => DeliveryServiceConfiguration.LowAircraftFactor;
        public override double HighFactor => DeliveryServiceConfiguration.HighAircraftFactor;
        public override double MediumFactor => DeliveryServiceConfiguration.MediumAircraftFactor;
    }
}
