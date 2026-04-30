using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    static class Extensions
    {
        static public string ToProductCode(this string code)
        {
            if (code == null)
            {
                return "SIN-CODIGO";
            }
            string codigoMayuscula = code.ToUpper().Trim();
            char[] codigoCaracteres = codigoMayuscula.ToCharArray();

            List<char> resultado = new List<char>();
            bool huboEspacio = false;

            foreach (char c in codigoCaracteres)
            {
                if (c == ' ')
                {
                    huboEspacio = true;
                }
                else
                {
                    if (huboEspacio)
                    {
                        resultado.Add('-');
                        huboEspacio = false;
                    }
                    resultado.Add(c);
                }
            }

            return new string(resultado.ToArray());
        }
    }
}
