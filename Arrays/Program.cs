using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ARRAYS");
            
            //Q1
            int[] arrayAleatorio = {-2,11,9,0,7,-5,15,3,1,14,9,-1,6,12,1,4,8,0,-3,10,2,-5,12,14,-1,5,-4};
            Console.WriteLine("\nQ1 - Encontre o segundo menor elemento de um Array\n- Input: {-2,11,9,0,7,-5,15,3,1,14,9,-1,6,12,1,4,8,0,-3,10,2,-5,12,14,-1,5,-4}");
            Console.WriteLine($"- Resposta: {Q1.SegundoMenor(arrayAleatorio)}");

            //Q2
            //É os 5 primeiros, pela pergunta não especificar a quantidade
            //Pela pergunta não especificar bem, foi decidido que é retornado os primeiros inteiros que não apareçam mais de uma vez,
             //ou seja, {1,1,2,3,3,4,5,6} = {2,4,5,6}
            Console.WriteLine("\nQ2 - Primeiros inteiros não repetidos de um Array\n- Input: {-2,11,9,0,7,-5,15,3,1,14,9,-1,6,12,1,4,8,0,-3,10,2,-5,12,14,-1,5,-4}");
            Console.WriteLine($"- Resposta: {Q2.ExibePrimeirosInteiros(arrayAleatorio)}");

            //Q3
            int[] arrayOrdenadoEsquerda = { -5, -2, -1, 0, 1, 1, 3, 6, 7, 9, 9, 11, 12, 14, 15 };
            int[] arrayOrdenadoDireita = { -5, -4, -3, -1, 0, 2, 4, 5, 8, 10, 12, 14 };
            Console.WriteLine("\nQ3 - Mescle dois Arrays ordenados\n- Input: {-5,-2,-1,0,1,1,3,6,7,9,9,11,12,14,15} e {-5,-4,-3,-1,0,2,4,5,8,10,12,14}");
            Console.WriteLine($"- Resposta: {Q3.ExibeArraysMesclados(arrayOrdenadoEsquerda, arrayOrdenadoDireita)}");

            //Q4
            Console.WriteLine("\nQ4 - Reordene os valores positivos e negativos em um Array\n- Input: {-2,11,9,0,7,-5,15,3,1,14,9,-1,6,12,1,4,8,0,-3,10,2,-5,12,14,-1,5,-4}");
            Console.WriteLine($"- Resposta: {Q4.Ordenar(arrayAleatorio)}");

        }
    }
}
