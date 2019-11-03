using Augen.TechnicalTest.Helper;

namespace Augen.TechnicalTest.Services
{
    public class TrainDeliveryInfo : DeliveryInfoBase
    {
        public string TrainNo => DeliveryHelper.GenerateName().ToUpper();
        public string StationOfArrival => DeliveryHelper.GenerateName();
        public TrainDeliveryInfo(double cost)
        {
            Cost = cost;
        }
        public override string GenerateInfo()
        {
            return string.Format(@"Train no: {0} | Station of arrival: {1} | Date of arrival: {2} | Cost: {3}",
                TrainNo,
                StationOfArrival,
                DeliveryDate.ToString("dd/MM/yyyy"),
                Cost);
        }
    }
}
