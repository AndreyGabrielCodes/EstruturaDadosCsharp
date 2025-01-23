using System.Collections.Generic;

namespace Dicionarios
{
    public class Q2
    {
        public static Dictionary<int, string> OrdenaJornada(Dictionary<int, string> jornadaNaoOrdenada)
        {
            Dictionary<int, string> jornadaOrdenada = new Dictionary<int, string>();
            int tamanhoDicionario = jornadaNaoOrdenada.Count;
            while (tamanhoDicionario != 0)
            {
                foreach (KeyValuePair<int, string> item in jornadaNaoOrdenada)
                {
                    if (ValidaMenorValor(jornadaNaoOrdenada, item.Key))
                    {
                        jornadaOrdenada.Add(item.Key, item.Value);
                        jornadaNaoOrdenada.Remove(item.Key);
                        tamanhoDicionario--;
                        break;
                    }
                }
            }
            return jornadaOrdenada;
        }

        private static bool ValidaMenorValor(Dictionary<int, string> jornadaNaoOrdenada, int valorComparacao)
        {
            foreach (int chave in jornadaNaoOrdenada.Keys)
            {
                if (chave < valorComparacao)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
