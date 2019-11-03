using Augen.TechnicalTest.Helper;
using System;

namespace Augen.TechnicalTest.Services
{
    public class MotorbikeDeliveryInfo : DeliveryInfoBase
    {
        public string DriverName => DeliveryHelper.GenerateName();
        public string Mobile => DeliveryHelper.GetRandomTelNo();
        public MotorbikeDeliveryInfo(double cost)
        {
            Cost = cost;
        }
        public override string GenerateInfo()
        {
            return string.Format(@"Driver name: {0} | Mobile: {1} | Delivery date: {2} | Cost: {3}", 
                DriverName, 
                Mobile, 
                DeliveryDate.ToString("dd/MM/yyyy"), 
                Cost);
        }
    }
}
