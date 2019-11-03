namespace Augen.TechnicalTest.Services
{
    public interface IDeliveryInfoGenerateService
    {
        string GenerateInfo(string deliveryService, double cost);
    }
}