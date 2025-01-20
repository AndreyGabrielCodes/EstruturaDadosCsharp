using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            int[] valores = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine($"\nQ1 - Implemente uma pilha usando uma fila\n- Input: ({string.Join(", ", valores)})");
            Console.WriteLine($"- Peek(): {Pilha.Q1.Peek(valores)}");
            Console.WriteLine($"- Push(): {Pilha.Q1.Push(valores, 11)}");
            Console.WriteLine($"- Pop(): {Pilha.Q1.Pop(valores)}");

            //Q2
            int tamanhoValores = valores.Length;
            int kPrimeiros = 5;
            Queue<int> queue = new Queue<int>();
            for(int i = 0; i < tamanhoValores; i++)
            {
                queue.Enqueue(valores[i]);
            }
            Console.WriteLine($"\nQ2 - Ordene inversamente os primeiros k elementos de uma fila\n- Input: ({string.Join(", ", valores)}) - {kPrimeiros} primeiros");
            Console.WriteLine($"- Resposta: {Q2.ExibeFilaAlterada(queue, kPrimeiros)}");

            //Q3
            int numeroMaximo = 12;
            Console.WriteLine($"\nQ3 - Gere números binários de 1 a n usando uma fila\n- Input: 1 a {numeroMaximo}");
            Console.WriteLine($"- Resposta: {Q3.ExibeNumerosDecimaisGerados(numeroMaximo)}");

        }
    }
}
