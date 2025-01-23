using System.Collections.Generic;

namespace Dicionarios
{
    public class Q4
    {
        public static bool ArraysDisjuntos(int[] array1, int[] array2)
        {
            Dictionary<int, int> contagemArray1 = ContaIncidenciaValor.TotalDeIncidencia(array1);
            Dictionary<int, int> contagemArray2 = ContaIncidenciaValor.TotalDeIncidencia(array2);
            foreach (int item in contagemArray1.Keys)
            {
                if (contagemArray2.ContainsKey(item))
                {
                    return false;
                }
            }
            return true;
        }
    }
}