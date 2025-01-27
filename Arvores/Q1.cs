using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arvores
{
    public class Q1
    {
        public static int Altura(TreeNode<int> no)
        {
            int altura = 0;
            int esquerda = 0;
            int direita = 0;
            if (no != null)
            {
                if (no.Left != null)
                {
                    esquerda +=  1 + Altura(no.Left);
                }
                if (no.Right != null)
                {
                    direita +=  1 + Altura(no.Right);
                }
                if (esquerda > direita)
                {
                    altura += esquerda;
                }
                else
                {
                    altura += direita;
                }
            }
            return altura;
        }
    }
}
