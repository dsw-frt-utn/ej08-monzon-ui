using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal partial class ProductHelper
    {
        public string ArmarCadena(long codigo, string descripcion, decimal precio)
        {
            return $"[{codigo}] {descripcion} - {precio}";
        }
    }
}
