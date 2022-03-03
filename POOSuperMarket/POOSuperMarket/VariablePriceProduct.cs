using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOSuperMarket
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }
        public decimal Quantity { get; set; }    
        public override decimal ValueToPay()
        {
            return Quantity;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
