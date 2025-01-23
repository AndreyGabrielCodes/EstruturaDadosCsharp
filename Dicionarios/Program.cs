using System;
using System.Collections.Generic;

namespace Dicionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            int[] arraySimetrico = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 2, 13, 4, 15, 16, 17, 18, 6, 10 };
            Console.WriteLine($"Q1 - Encontre pares simétricos em um Array\n- Input: ({string.Join(",", arraySimetrico)})");
            Console.WriteLine($"- Resposta: {Q1.ExibeParesEncontrados(arraySimetrico)}");

            //Q2
            //Como a pergunta não especifica qual a jornada e não fala o que fazer com ela,
            // será inicializado um dicionário com uma sequencia de passos não ordenados
            // para pedir um Ifood e o objetivo será retorná-los na ordem correta
            Dictionary<int, string> jornadaNaoOrdenadaPedirIfood = new Dictionary<int, string>
            {
                {4, "Ir para o carrinho" },
                {6, "Confirmar pedido" },
                {3, "Adicionar comida ao carrinho" },
                {1, "Abrir aplicativo do Ifood" },
                {5, "Escolher método de pagamento" },
                {2, "Pesquisar restaurante" }
            };
            Console.WriteLine($"\nQ2 - Trace o caminho completo de uma jornada\n- Input: ({string.Join(",", jornadaNaoOrdenadaPedirIfood)})");
            Console.WriteLine($"- Resposta: ({string.Join(",", Q2.OrdenaJornada(jornadaNaoOrdenadaPedirIfood))})");

            //Q3
            int[] arrayPrincipal = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10};
            int[] subconjunto1 = { 10, 11, 12 };
            int[] subconjunto2 = { 4, 5, 6 };
            int[] subconjunto3 = { 2, 10 };
            Console.WriteLine($"\nQ3 - Descubra se um Array é um subconjunto de outro Array");
            Console.WriteLine($"- Input: ({string.Join(",", arrayPrincipal)}) e ({string.Join(",", subconjunto1)}) e ({string.Join(",", subconjunto2)}) e ({string.Join(",", subconjunto3)}) ");
            Console.WriteLine($"- Resposta: {Q3.ArraySubconjunto(arrayPrincipal, subconjunto1)} e {Q3.ArraySubconjunto(arrayPrincipal, subconjunto2)} e {Q3.ArraySubconjunto(arrayPrincipal, subconjunto3)}");

            //Q4
            //São usados os mesmos arrays do exercício anterior para poupar código
            Console.WriteLine($"\nQ4 - Verifique se determinados Arrays são disjuntos (não possuem elementos em comum)");
            Console.WriteLine($"- Input: ({string.Join(",", subconjunto1)}) e ({string.Join(",", subconjunto2)}) | ({string.Join(",", subconjunto1)}) e ({string.Join(",", subconjunto3)}) ");
            Console.WriteLine($"- Resposta: {Q4.ArraysDisjuntos(subconjunto1, subconjunto2)} e {Q4.ArraysDisjuntos(subconjunto1, subconjunto3)}");
        }
    }
}
