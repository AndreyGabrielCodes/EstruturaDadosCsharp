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
            Console.WriteLine($"Q1 - Ordene inversamente uma lista vinculada\n- Input: ({string.Join(",", numeros)})");
            Console.WriteLine($"- Resposta: ({Q1.ExibeListaInvertida(numeros)})");

            //Q2
            Console.WriteLine($"\nQ2 - Detecte um loop (laço) em uma lista vinculada");
            Console.WriteLine($"- Resposta: {Q2.ExibeNoEncontrado(numeros)}");

            //Q3
            int enesimoNo = 9;
            Console.WriteLine($"\nQ3 - Retorne o enésimo nó partindo do final de uma lista vinculada");
            Console.WriteLine($"- Input: {enesimoNo} e ({string.Join(",", numeros)})");
            Console.WriteLine($"- Resposta: {Q3.RetornaValorEnesimoNo(numeros, enesimoNo)}");
        }
    }
}
