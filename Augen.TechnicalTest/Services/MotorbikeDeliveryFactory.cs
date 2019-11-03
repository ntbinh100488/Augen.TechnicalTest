namespace Augen.TechnicalTest.Services
{
    public class MotorbikeDeliveryFactory : DeliveryFactory
    {
        public override DeliveryBase GetDelivery()
        {
            return new MotorbikeDelivery();
        }
    }
}