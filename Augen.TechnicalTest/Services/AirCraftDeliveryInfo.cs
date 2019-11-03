using Augen.TechnicalTest.Helper;

namespace Augen.TechnicalTest.Services
{
    public class AirCraftDeliveryInfo : DeliveryInfoBase
    {
        public string FlightNo => DeliveryHelper.GenerateName().ToUpper();
        public string GateOfArrival => DeliveryHelper.GenerateFullName();
        public AirCraftDeliveryInfo(double cost)
        {
            Cost = cost;
        }
        public override string GenerateInfo()
        {
            return string.Format(@"Flight no: {0} | Gate of arrival: {1} | Date of arrival: {2} | Cost: {3}",
                FlightNo,
                GateOfArrival,
                DeliveryDate.ToString("dd/MM/yyyy"),
                Cost);
        }
    }
}
