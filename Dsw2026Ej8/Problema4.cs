using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            int suma = 0;
            int cantidad = 0;

            if (nota1 == null && nota2 == null && nota3 == null)
            {
                return 0;
            }
            else
            {
                int n1 = nota1 ?? -1;
                int n2 = nota2 ?? -1;
                int n3 = nota3 ?? -1;

                int[] notas = { n1, n2, n3 };

                for (int i = 0; i < 3; i++)
                {
                    if (notas[i]>=0 || notas[i]<=10)
                    {
                        suma = suma + notas[i];
                        cantidad++;
                    }
                }
                return suma / cantidad;
            }

            
        }
    }
}
