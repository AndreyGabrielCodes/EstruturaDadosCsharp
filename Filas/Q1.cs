using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha
{
    public class Q1
    {
        //armazena e retira o valor atual até que não consiga retirar 
          //o próximo e então retorna o ultimo valor armazenado
        public static int Peek(int[] valores)
        {
            Queue<int> queue = ConverteArrayParaQueue(valores);
            int valorAnterior = 0;
            int tamanhoQueue = queue.Count;

            for (int i = 0; i < tamanhoQueue; i++)
            {
                try
                {
                    queue.Peek();
                    valorAnterior = queue.Dequeue();
                }
                catch
                {
                    break;
                }
            }
            return valorAnterior;
        }

        public static void Push(int[] valores)
        {

        }

        public static void Pop(int[] valores)
        {

        }

        private static Queue<int> ConverteArrayParaQueue(int[] array)
        {
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < array.Length; i++)
            {
                queue.Enqueue(array[i]);
            }
            return queue;
        }

    }
}
