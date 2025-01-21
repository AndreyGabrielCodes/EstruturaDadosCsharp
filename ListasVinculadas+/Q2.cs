using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasVinculadas
{
    public class Q2
    {
        public static bool ExibeNoEncontrado(LinkedList<int> lista)
        {
            LinkedListNode<int> no = lista.First;
            int numeroIteracoesMaxima = lista.Count;
            int numeroIteracoes = 0;
            while (no != null)
            {
                no = no.Next;
                numeroIteracoes++;
                if (numeroIteracoes > numeroIteracoesMaxima)
                {
                    return true;
                }
            }
            return false;

        }
    }
}
