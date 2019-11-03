using System;

namespace Augen.TechnicalTest.Services
{
    public class AircraftDelivery : DeliveryBase
    {
        public override DeliveryServiceTypes ServiceType => DeliveryServiceTypes.Aircraft;

        public override int BaseCost => 20;

        public override double GetFactor()
        {
            var currentMonth = DateTime.Now.Month;

            if (currentMonth >= 6 && currentMonth <= 8)
            {
                return 0.8;
            }
            else if (currentMonth == 9)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }
    }
}
