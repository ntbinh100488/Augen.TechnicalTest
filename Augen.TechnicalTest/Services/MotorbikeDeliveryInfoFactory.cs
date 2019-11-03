namespace Augen.TechnicalTest.Services
{
    public class MotorbikeDeliveryInfoFactory : DeliveryInfoFactory
    {
        public override DeliveryInfoBase GetDeliveryInfo(double cost)
        {
            return new MotorbikeDeliveryInfo(cost);
        }
    }
}
