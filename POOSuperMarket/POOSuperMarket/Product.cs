using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOSuperMarket
{
    public abstract class Product
    {
        public string Description { get; set; }
        public int Id { get; set; }
        public decimal Price { get; set; }
        public float Tax { get; set; }

        public abstract decimal ValueToPay();
        public override string ToString()
        {
            return $"{Description}, " +
                   $"Código: {Id}, " +
                   $"Precio: {Price}, " +
                   $"Impuesto: {Tax}";
        }

    }
}
