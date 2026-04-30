using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema2
    {
        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            decimal total;
            var resumen = new {code = productCode, description = productDescription, cantidad = quantity};
            if (resumen.cantidad <= 0)
            {
                total = 0;
            }
            else
            {
                total = resumen.cantidad * unitPrice;
            }

            return $"{resumen.code}-{resumen.cantidad}-{total}";
        }
    }
}
