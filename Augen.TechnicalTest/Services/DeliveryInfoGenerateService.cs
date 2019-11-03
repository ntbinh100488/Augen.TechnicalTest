namespace Augen.TechnicalTest.Services
{
    public class DeliveryInfoGenerateService : IDeliveryInfoGenerateService
    {
        public string GenerateInfo(string deliveryService, double cost)
        {
            DeliveryInfoFactory deliveryInfoFactory;
            switch (deliveryService)
            {
                case "motorbike":
                    deliveryInfoFactory = new MotorbikeDeliveryInfoFactory();
                    return deliveryInfoFactory.GetDeliveryInfo(cost).GenerateInfo();
                case "train":
                    deliveryInfoFactory = new TrainDeliveryInfoFactory();
                    return deliveryInfoFactory.GetDeliveryInfo(cost).GenerateInfo();
                case "aircraft":
                    deliveryInfoFactory = new AircraftDeliveryInfoFactory();
                    return deliveryInfoFactory.GetDeliveryInfo(cost).GenerateInfo();
                    
                default:
                    break;
            }

            return "";
        }
    }
}
