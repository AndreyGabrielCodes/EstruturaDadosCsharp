using System.Collections.Generic;

namespace Dicionarios
{
    public class ContaIncidenciaValor
    {
        public static Dictionary<int, int> TotalDeIncidencia(int[] array)
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
