using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicionarios
{
    public class Q3
    {
        public static bool ArraySubconjunto(int[] arrayPrincipal, int[] subconjunto)
        {
            Dictionary<int, int> contagemArrayPrincipal = ContaIncidenciaValor(arrayPrincipal);
            
            foreach (KeyValuePair<int,int> item in contagemArrayPrincipal)
            {

            }

            
            return false;
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
