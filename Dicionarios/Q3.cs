using System.Collections.Generic;

namespace Dicionarios
{
    public class Q3
    {
        public static bool ArraySubconjunto(int[] arrayPrincipal, int[] subconjunto)
        {
            Dictionary<int, int> contagemArrayPrincipal = ContaIncidenciaValor.TotalDeIncidencia(arrayPrincipal);
            int valoresContidosNoArray = 0;
            foreach (int item in subconjunto)
            {
                foreach (KeyValuePair<int, int> itemContagem in contagemArrayPrincipal)
                {
                    if (item == itemContagem.Key && itemContagem.Value > 0)
                    {
                        valoresContidosNoArray++;
                        break;
                    }
                }
            }
            if (valoresContidosNoArray != subconjunto.Length)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
