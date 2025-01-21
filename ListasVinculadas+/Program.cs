using System;
using System.Collections.Generic;

namespace ListasVinculadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            LinkedList<int> numeros = new LinkedList<int>();
            int numeroElementos = 10;
            for (int i = 0; i < numeroElementos; i++)
            {
                numeros.AddLast(i);
            }
            Console.WriteLine($"Q1 - Ordene inversamente uma lista vinculada\n-Input: ({string.Join(",", numeros)})");
            Console.WriteLine($"- Resposta: ({Q1.ExibeListaInvertida(numeros)})");

            //Q2
            LinkedList<int> numerosComLoop = numeros;
            LinkedListNode<int> primeiroNo = numerosComLoop.First;
            primeiroNo.Next = numerosComLoop.First;
            Console.WriteLine($"\nQ2 - Detecte um loop (laço) em uma lista vinculada");
            Console.WriteLine($"- Resposta: {Q2.ExibeNoEncontrado(numeros)} e {Q2.ExibeNoEncontrado(numerosComLoop)}");
        }
    }
}
