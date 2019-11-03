using System;

namespace Augen.TechnicalTest.Services
{
    public class TrainDelivery : DeliveryBase
    {
        public override DeliveryServiceTypes ServiceType => DeliveryServiceTypes.Train;
        public override int BaseCost => 10;
        public override double GetFactor()
        {
            var currentMonth = DateTime.Now.Month;

            if (currentMonth >= 6 && currentMonth <= 8)
            {
                return 0.8;
            }
            else if (currentMonth == 9)
            {
                return 1.8;
            }
            else
            {
                return 1;
            }
        }
    }
}
