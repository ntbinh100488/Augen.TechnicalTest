using System;

namespace Augen.TechnicalTest.Services
{
    public abstract class DeliveryBase
    {
        public abstract DeliveryServiceTypes ServiceType { get; }
        public abstract double BaseCost { get; }
        public abstract double LowFactor { get; }
        public abstract double HighFactor { get; }
        public abstract double MediumFactor { get; }
        public double GetFactor() 
        {
            var currentMonth = DateTime.Now.Month;

            if (currentMonth >= 6 && currentMonth <= 8)
            {
                return LowFactor;
            }
            else if (currentMonth == 9)
            {
                return HighFactor;
            }
            else
            {
                return MediumFactor;
            }
        }
        public double GetDeliveryCost()
        {
            return BaseCost * GetFactor();
        }
    }
}