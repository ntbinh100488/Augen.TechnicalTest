namespace Augen.TechnicalTest.Services
{
    public class TrainDeliveryInfoFactory : DeliveryInfoFactory
    {
        public override DeliveryInfoBase GetDeliveryInfo(double cost)
        {
            return new TrainDeliveryInfo(cost);
        }
    }
}
