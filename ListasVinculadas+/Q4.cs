using System.Collections.Generic;

namespace ListasVinculadas
{
    public class Q4
    {
        public static LinkedList<int> RemoveDuplicados(LinkedList<int> lista)
        {
            LinkedListNode<int> noPrimario = lista.First;

            while (noPrimario != null)
            {
                LinkedListNode<int> noSecundario = lista.First.Next;
                while (noSecundario != null)
                {
                    if (noSecundario.Value == noPrimario.Value)
                    {
                        lista.Remove(noPrimario.Value);
                        lista.Remove(noSecundario.Value);
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
