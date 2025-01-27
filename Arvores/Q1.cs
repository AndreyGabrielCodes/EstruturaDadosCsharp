using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arvores
{
    public class Q1
    {
        public static void Altura(TreeNode<int> no)
        {
            List<int> alturas = new List<int>();
            CalculaAltura(no.Left);

        }
        
        private static void CalculaAltura(TreeNode<int> no)
        {
            if (no != null)
            {
                int esquerda = PercorreEsquerda(no.Left);
                int direita = PercorreDireita(no.Right);
                Console.WriteLine(esquerda);
                Console.WriteLine(direita);
            }
        }

        private static int PercorreEsquerda(TreeNode<int> no)
        {
            if (no != null)
            {
                PercorreEsquerda(no.Left);
            }
            return 1;
        }
        
        private static int PercorreDireita(TreeNode<int> no)
        {
            if (no != null)
            {
                PercorreDireita(no.Right);
            }
            return 1;
        }
    }
}
