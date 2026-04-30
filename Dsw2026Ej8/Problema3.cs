using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int copy = originalValue;
            Product productref = product;
            productref.setDescription("Descripcion modificada");
            return $"{originalValue}-{copy}-{product.getDescription()}";
        }
    }
}
