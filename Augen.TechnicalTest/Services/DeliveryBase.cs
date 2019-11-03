namespace Augen.TechnicalTest.Services
{
    public abstract class DeliveryBase
    {
        public abstract DeliveryServiceTypes ServiceType { get; }
        public abstract int BaseCost { get; }
        public abstract double GetFactor();
        public double GetDeliveryCost()
        {
            return BaseCost * GetFactor();
        }
    }
}