using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOSuperMarket
{
    public class Invoice : IPay
    {
        private List<Product> _products;

        public Invoice( )
        {
            _products = new List <Product>();
        }

        public Product AddProduct(Product newProduct)
        {
            _products.Add( newProduct ); 
            return newProduct;
        }
        public decimal ValueToPay()
        {
            decimal value = 0;
            foreach (Product product in _products)
            {
                value += product.ValueToPay();  
            }
            return value;
        }

        public override string ToString()
        {
            return $"Bill \n" +
                $"_products" +
                $"\n" +
                $"Total: {$"{ValueToPay()}:C2",18}";
        }

    }
}
