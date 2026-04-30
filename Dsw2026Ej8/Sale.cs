using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Sale
    {
        protected List<Product> _products;
        public virtual decimal CalculateTotal()
        {
            return 0;
        }

        public Sale(List<Product> products)
        {
            _products = products;
        }


        public List<Product> GetProducts()
        {
            return _products;
        }

        public void SetProducts(List<Product> products)
        {
            _products = products;
        }
    }
}
