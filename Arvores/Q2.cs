using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arvores
{
    public class Q2
    {
        private static List<int> valoresArvore = new List<int>();
        private static Action<int> adicionaValorNo = x => AdicionaElemento(x); 


        public static int KEsimoMaior(int k, BinaryTree<int> arvore)
        {
            arvore.InOrderTraversal(adicionaValorNo);
            return valoresArvore.Max();
        }


        private static void AdicionaElemento(int valor)
        {
            valoresArvore.Add(valor);
        }

    }
}
