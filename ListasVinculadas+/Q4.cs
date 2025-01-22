using System;
using System.Collections.Generic;

namespace ListasVinculadas
{
    public class Q4
    {
        //compara o valor atual com os seguintes ao mesmo tempo compara os "indices" deles
        // quando o valor atual e o seguinte forem iguais e o "indice" for diferente,
        // os dois são retirados
        public static LinkedList<int> RemoveDuplicados(LinkedList<int> lista)
        {
            LinkedListNode<int> noPrimario = lista.First;
            int numeroIteracaoPrimaria = 0;
            while (noPrimario != null)
            {
                numeroIteracaoPrimaria++;
                LinkedListNode<int> noSecundario = lista.First;
                int numeroIteracaoSecundaria = 0;
                while (noSecundario != null)
                {
                    numeroIteracaoSecundaria++;
                    if (noSecundario.Value == noPrimario.Value && numeroIteracaoPrimaria != numeroIteracaoSecundaria)
                    {
                        int valorNoPrimarioTemp = noPrimario.Value;
                        int valorNoSecundarioTemp = noSecundario.Value;
                        noPrimario = noPrimario.Next;
                        noSecundario = noSecundario.Next;
                        lista.Remove(valorNoPrimarioTemp);
                        lista.Remove(valorNoSecundarioTemp);
                        break;
                    }
                    noSecundario = noSecundario.Next;
                }
                noPrimario = noPrimario.Next;
            }
            return lista;
        }
    }
}
