using System.Collections.Generic;

namespace ListasVinculadas
{
    public class Q3
    {


        public static string RetornaValorEnesimoNo(LinkedList<int> lista, int enesimoNo)
        {
            if (!ValidaValorEnesimoNo(enesimoNo, lista))
            {
                return "Valor inserido em Enesimo Nó é maior que o tamanho da lista";
            }
            int quantidadeIteracao = CalculaIteracoes(RetornaTamanhoLista(lista), enesimoNo);
            LinkedListNode<int> no = lista.Last;
            for (int i = 0; i < quantidadeIteracao; i++)
            {
                no = no.Previous;
            }
            return no.Value.ToString();
        }

        private static bool ValidaValorEnesimoNo(int enesimoNo, LinkedList<int> lista)
        {
            if (enesimoNo > RetornaTamanhoLista(lista))
            {
                return false;
            }
            return true;
        }

        private static int CalculaIteracoes(int tamanhoLista, int enesimoNo)
        {
            int quantidadeIteracao = tamanhoLista - enesimoNo;
            return quantidadeIteracao;
        }

        private static int RetornaTamanhoLista(LinkedList<int> lista)
        {
            LinkedListNode<int> no = lista.Last;
            int tamanhoLista = 0;
            while (no != null)
            {
                no = no.Previous;
                tamanhoLista++;
            }
            return tamanhoLista;
        }
    }
}
