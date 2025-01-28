using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arvores
{
    public class Q4
    {
        private static List<int> valoresNivel = new List<int>();

        public static string Ancestrais(BinaryTree<int> arvore, int kNo)
        {
            if (!arvore.Search(kNo))
            {
                return "Nó inserido não existe na arvore!";
            }
            else
            {
                EncontraAncestrais(arvore.Root, kNo);
                return "(" + string.Join(",", valoresNivel) + ")";
            }
        }

        private static void EncontraAncestrais(TreeNode<int> no, int kNo, bool noEncontrado = false)
        {
            if (no != null && no.Value != kNo && !noEncontrado)
            {
                if (no.Left != null)
                {
                    EncontraAncestrais(no.Left, kNo);
                }
                if (no.Right != null)
                {
                    EncontraAncestrais(no.Right, kNo);
                }
            }
            else if (no.Value == kNo || noEncontrado == true)
            {
                if (no.Left != null)
                {
                    AdicionaValorAncestral(no.Left.Value);
                    EncontraAncestrais(no.Left, kNo, true);
                }
                if (no.Right != null)
                {
                    AdicionaValorAncestral(no.Right.Value);
                    EncontraAncestrais(no.Right, kNo, true);
                }
            }
        }

        private static void AdicionaValorAncestral(int valor)
        {
            valoresNivel.Add(valor);
        }
    }
}
