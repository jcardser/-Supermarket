    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOSuperMarket
{
    public class ComposedProduct : Product
    {
        public decimal Discount { get; set; }  
        public List<Product> Products { get; set; }
        public override decimal ValueToPay()
        {
            decimal Pay = 0;
            foreach (Product product in Products)
            {
                Pay +=product.ValueToPay(); 
            }
            return Pay - (Pay * Discount);    
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
