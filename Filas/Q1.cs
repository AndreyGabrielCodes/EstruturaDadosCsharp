﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha
{
    public class Q1
    {
        public static string Push(int[] valores, int incluirValor)
        {
            Queue<int> queue = ConverteArrayParaQueue(valores);
            queue.Enqueue(incluirValor);
            return "(" + string.Join(",", queue) + ")";
        }

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
                    valorAnterior = queue.Dequeue();
                }
                catch
                {
                    break;
                }
            }
            return valorAnterior;
        }

        //armazena e retira o valor atual para uma nova queue
         //apenas na iteração seguinte
         //até que não consiga retirar o próximo
         //e então retorna a queue sem o ultimo valor
        public static string Pop(int[] valores)
        {
            Queue<int> queue = ConverteArrayParaQueue(valores);
            Queue<int> queueAlterada = new Queue<int>();
            int tamanhoQueue = queue.Count;
            int valorAnterior = 0;
            for (int i = 0; i < tamanhoQueue; i++)
            {
                if (i > 0)
                {
                    queueAlterada.Enqueue(valorAnterior);
                }
                try
                {
                    valorAnterior = queue.Dequeue();
                }
                catch
                {
                    break;
                }
            }
            return "(" + string.Join(",", queueAlterada) + ")";
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
