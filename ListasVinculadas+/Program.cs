using System;
using System.Collections.Generic;

namespace ListasVinculadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            int[] array = { 1, 2, 3, 4, 5, 6, 7 ,8 ,9, 10};
            LinkedList<int> numeros = new LinkedList<int>(array);
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

            //Q4
            int[] numerosDuplicados = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 4, 15, 16, 17, 18, 6, 10 };
            Console.WriteLine($"\nQ4 - Remova elementos duplicados de uma lista vinculada");
            Console.WriteLine($"- Input: ({string.Join(",", numerosDuplicados)})");
            Console.WriteLine($"- Resposta: {string.Join(",",Q4.RemoveDuplicados(numeros))}");
        }
    }
}
