using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Q3
    {
        public static void ExibeArraysMesclados(int[] arrayEsquerda, int[] arrayDireita)
        {
            int[] arrayExibicao = MesclaArrays(arrayEsquerda, arrayDireita);
            
            foreach(int i in arrayExibicao)
            {
                Console.WriteLine(i);
            }
        }
        /*private static int[] MesclaArrays(int[] arrayEsquerda, int[] arrayDireita)
        {
            
        }*/

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
