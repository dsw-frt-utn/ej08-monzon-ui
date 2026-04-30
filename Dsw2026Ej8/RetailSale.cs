using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class RetailSale : Sale
    {
        public override decimal CalculateTotal()
        {
            foreach (Product p in _products)
            {
                return p.getPrice() * p.getQuantity();
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

        
         public RetailSale(List<Product> products) : base(products)
        {
        }

    }
}
