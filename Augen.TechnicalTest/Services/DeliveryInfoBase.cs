using Augen.TechnicalTest.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Augen.TechnicalTest.Services
{
    public abstract class DeliveryInfoBase
    {
        public double Cost { get; set; }
        public DateTime DeliveryDate => DeliveryHelper.GetRandomDate();
        public abstract string GenerateInfo();
    }
}
