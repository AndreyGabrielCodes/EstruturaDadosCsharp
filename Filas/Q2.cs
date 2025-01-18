using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filas
{
    public class Q2
    {
        public static string ExibeFilaAlterada(Queue<int> queue, int kPrimeiros)
        {
            string filaAlterada = string.Join(",",RetiraKPrimeirosElementos(queue, kPrimeiros));
            return filaAlterada;
        }

        private static Queue<int> RetiraKPrimeirosElementos(Queue<int> queue, int kPrimeiros)
        {
            Stack<int> primeirosElementos = new Stack<int>();
            for (int i = 0; i < kPrimeiros; i++)
            {
                primeirosElementos.Push(queue.Dequeue());
            }
            queue = OrdenaKPrimeirosInversamente(queue, primeirosElementos, kPrimeiros);
            return queue;
        }

        private static Queue<int> OrdenaKPrimeirosInversamente(Queue<int> queueRestante, Stack<int> stack, int kPrimeiros)
        {
            Queue<int> queueAlterada = new Queue<int>();
            for (int i = 0; i < kPrimeiros; i++)
            {
                queueAlterada.Enqueue(stack.Pop());
            }
            queueAlterada = AdicionaElementosRestantes(queueAlterada, queueRestante);
            return queueAlterada;
        }

        private static Queue<int> AdicionaElementosRestantes(Queue<int> queueAlterada, Queue<int> queueRestante)
        {
            int tamanhoQueueRestante = queueRestante.Count;
            for (int i = 0; i < tamanhoQueueRestante; i++)
            {
                queueAlterada.Enqueue(queueRestante.Dequeue());
            }
            return queueAlterada;
        }
    }
}