using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arvores
{
    public class Q3
    {
        private static List<int> valoresNivel = new List<int>();

        public static void kEsimosNos(BinaryTree<int> arvore, int distanciaK)
        {
            if (distanciaK > Q1.Altura(arvore.Root))
            {
                Console.WriteLine("DistanciaK maior que nível da arvore!");
            }
            else
            {
                Altura(arvore.Root, distanciaK);
                Console.WriteLine("(" + string.Join(",", valoresNivel) + ")");
            }
        }

        private static void Altura(TreeNode<int> no, int distanciaK, int nivelAtual = 0 )
        {
            if (no != null && nivelAtual != distanciaK)
            {
                nivelAtual++;
                if (no.Left != null)
                {
                    Altura(no.Left, distanciaK, nivelAtual);
                }
                if (no.Right != null)
                {
                    Altura(no.Right, distanciaK, nivelAtual);
                }
            }
            else if (nivelAtual == distanciaK)
            {
                AdicionaValorNo(no.Value);
            }
        }

        private static void AdicionaValorNo(int valor)
        {
            valoresNivel.Add(valor);
        }
    }
}
