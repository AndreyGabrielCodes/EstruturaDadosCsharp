using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Q3
    {
        public static string ExibeArraysMesclados(int[] arrayEsquerda, int[] arrayDireita)
        {
            string arrayExibicao = string.Join(",", OrdenaArray.Ordenar(MesclaArrays(arrayEsquerda, arrayDireita)));
            return "{" + arrayExibicao + "}";
        }
        
        private static int[] MesclaArrays(int[] arrayEsquerda, int[] arrayDireita)
        {
            int tamanhoTotal = arrayEsquerda.Length + arrayDireita.Length;
            int[] arrayMesclado = new int[tamanhoTotal];
            for (int i = 0; i < arrayEsquerda.Length; i++)
            {
                arrayMesclado[i] = arrayEsquerda[i];
            }
            for (int i = arrayEsquerda.Length, j = 0; j < arrayDireita.Length; i++, j++)
            {
                arrayMesclado[i] = arrayDireita[j];
            }
            return arrayMesclado;
        }
    }
}
