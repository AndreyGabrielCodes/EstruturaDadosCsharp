using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasVinculadas_
{
    public class Q1
    {

        public static string ExibeListaInvertida(LinkedList<int> numeros)
        {
            string listaAlterada = string.Join(",", InverteLista(numeros));
            return listaAlterada;
        }

        private static LinkedList<int> InverteLista(LinkedList<int> numeros) 
        {
            LinkedList<int> listaAlterada = new LinkedList<int>();
            foreach (int numero in numeros.Reverse()) {
                listaAlterada.AddLast(numero);
            }
            return listaAlterada;
        }
    }
}
