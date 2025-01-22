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
            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho; j++)
                {
                    if (array[i] == array[j] && i != j)
                    {
                        numeroParEncontrado++;
                        int[] paresTemp = {array[i], array[j]};
                        paresSimetricos.Add($"Par {numeroParEncontrado}", paresTemp);
                    }
                }
            }
            return paresSimetricos;
        }
    }
}
