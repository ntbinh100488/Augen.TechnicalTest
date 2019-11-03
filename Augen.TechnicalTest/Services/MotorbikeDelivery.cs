using System;

namespace Augen.TechnicalTest.Services
{
    public class MotorbikeDelivery : DeliveryBase
    {
        public override DeliveryServiceTypes ServiceType => DeliveryServiceTypes.Motobike;
        public override int BaseCost => 5;
        public override double GetFactor()
        {
            var currentMonth = DateTime.Now.Month;

            if (currentMonth >= 6 && currentMonth <= 8)
            {
                return 0.5;
            }
            else if (currentMonth == 9)
            {
                return 1.5;
            }
            else
            {
                return 1;
            }
        }
    }
}
