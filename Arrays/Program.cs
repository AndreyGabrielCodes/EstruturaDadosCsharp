using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ARRAYS\n");
            
            //Q1
            int[] arrayAleatorio = {2,10,5,7,4,9,6,1,3,8,2,1,4,7,9,10};
            Console.WriteLine("Q1 - Encontre o segundo menor elemento de um Array\n- Input: {2,10,5,7,4,9,6,1,3,8,2,1,4,7,9,10}");
            Console.WriteLine($"- Resposta: {Q1.RetornaSegundoMenor(arrayAleatorio)}");
        }
    }
}
