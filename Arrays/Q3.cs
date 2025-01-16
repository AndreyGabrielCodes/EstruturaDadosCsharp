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
            int[] arrayOrdenado = OrdenaArray(MesclaArrays(arrayEsquerda, arrayDireita));
            string arrayExibicao = string.Join(",", arrayOrdenado);
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

        private static int[] OrdenaArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
    }
}
