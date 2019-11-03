using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Augen.TechnicalTest.Services
{
    public class TrainDeliveryFactory : DeliveryFactory
    {
        public override DeliveryBase GetDelivery()
        {
            return new TrainDelivery();
        }
    }
}
