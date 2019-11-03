namespace Augen.TechnicalTest.Services
{
    public class AircraftDeliveryFactory : DeliveryFactory
    {
        public override DeliveryBase GetDelivery()
        {
            return new AircraftDelivery();
        }
    }
}