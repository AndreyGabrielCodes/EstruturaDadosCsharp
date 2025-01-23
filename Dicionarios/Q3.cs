using System.Collections.Generic;

namespace Dicionarios
{
    public class Q3
    {
        public static bool ArraySubconjunto(int[] arrayPrincipal, int[] subconjunto)
        {
            Dictionary<int, int> contagemArrayPrincipal = ContaIncidenciaValor(arrayPrincipal);
            int valoresContidosNoArray = 0;
            int totalValoresSubconjunto = subconjunto.Length;
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
            if (valoresContidosNoArray != totalValoresSubconjunto)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static Dictionary<int, int> ContaIncidenciaValor(int[] array)
        {
            Dictionary<int, int> contagemDeValores = new Dictionary<int, int>();
            foreach (int i in array)
            {
                int contagemValor = 0;
                if (contagemDeValores.ContainsKey(i))
                {
                    contagemDeValores[i]++;
                }
                else
                {
                    foreach (int j in array)
                    {
                        if (i == j)
                        {
                            contagemValor++;
                            contagemDeValores.Add(i, contagemValor);
                            break;
                        }
                    }
                }
            }
            return contagemDeValores;
        }
    }
}
