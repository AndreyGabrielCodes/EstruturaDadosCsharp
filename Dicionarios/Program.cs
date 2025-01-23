using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            int[] arraySimetrico = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 2, 13, 4, 15, 16, 17, 18, 6, 10 };
            Console.WriteLine($"Q1 - Encontre pares simétricos em um Array\n- Input: ({string.Join(",",arraySimetrico)})");
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

        }
    }
}
