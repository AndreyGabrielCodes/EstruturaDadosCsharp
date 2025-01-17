using System;
using System.Collections.Generic;

namespace Pilhas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            string expressao = "3 4+ 2 * 5 - 2 /";
            Console.WriteLine("\nQ1 - Calcule o valor de uma expressão pós-fixada usando uma pilha\n- Input: {3 4+ 2 * 5 - 2 /}");
            Console.WriteLine($"- Resposta: {Q1.SeparaCaracteres(expressao)}"); //Q1

            //Q2
            int[] arrayAleatorio = { -2, 11, 9, 0, 7, -5, 15, 3, 1, 14, 9, -1, 6, 12, 1, 4, 8, 0, -3, 10, 2, -5, 12, 14, -1, 5, -4 };
            Stack<int> stackAleatorio = new Stack<int> { };
            foreach (int i in arrayAleatorio)
            {
                stackAleatorio.Push(i);
            }
            Console.WriteLine("\nQ2 - Ordene valores em uma pilha\n- Input: {-2,11,9,0,7,-5,15,3,1,14,9,-1,6,12,1,4,8,0,-3,10,2,-5,12,14,-1,5,-4}");
            Console.WriteLine($"- Resposta: {Q1.SeparaCaracteres(expressao)}");



        }
    }
}
