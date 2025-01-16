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
        }
    }
}
