using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicionarios
{
    public class Q1
    {
        public static string ExibeParesEncontrados(int[] array)
        {
            Dictionary<string, int[]> paresSimetricos = new Dictionary<string, int[]>();
            paresSimetricos = EncontraPares(array);
            string texto = "";
            foreach (KeyValuePair<string, int[]> item in paresSimetricos)
            {
                texto += item.Key + ": (" +string.Join(",", item.Value) + "), ";
            }
            return texto;
        }

        private static Dictionary<string, int[]> EncontraPares(int[] array)
        {
            Dictionary<string, int[]> paresSimetricos = new Dictionary<string, int[]>();
            int tamanho = array.Length;
            int numeroParEncontrado = 0;
            List<int> simetricosEncontrados = new List<int>();
            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho; j++)
                {
                    if (array[i] == array[j] && i != j)
                    {
                        if (ValidaParEncontrado(simetricosEncontrados, array[i], array[j]))
                        {
                            numeroParEncontrado++;
                            simetricosEncontrados.Add(array[i]);
                            int[] paresTemp = { array[i], array[j] };
                            paresSimetricos.Add($"Par {numeroParEncontrado}", paresTemp);
                        }
                    }
                }
            }
            return paresSimetricos;
        }

        private static bool ValidaParEncontrado(List<int> simetricosEncontrados, int par1, int par2)
        {
            bool parValido = true;
            foreach (int parEncontrado in simetricosEncontrados)
            {
                if (par1 == parEncontrado || par2 == parEncontrado)
                {
                    parValido = false;
                }
            }
            return parValido;
        }
    }
}
