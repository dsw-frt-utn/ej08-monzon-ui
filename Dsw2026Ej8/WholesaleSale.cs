using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class WholesaleSale : Sale
    {
        

        public override decimal CalculateTotal()
        {
            foreach (Product p in _products)
            {
                return (p.getPrice() * p.getQuantity()) - (p.getPrice() * p.getQuantity())*0.1m;
            }
            if (_products.Count == 0)
            {
                return 0;
            }
            else
            {
                return 0;
            }
        }

        public WholesaleSale(List<Product> products) : base(products)
        {
        }




    }
}
