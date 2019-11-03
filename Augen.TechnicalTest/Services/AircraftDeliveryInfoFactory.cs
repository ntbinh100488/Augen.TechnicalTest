namespace Augen.TechnicalTest.Services
{
    public class AircraftDeliveryInfoFactory : DeliveryInfoFactory
    {
        public override DeliveryInfoBase GetDeliveryInfo(double cost)
        {
            return new AirCraftDeliveryInfo(cost);
        }
    }
}
