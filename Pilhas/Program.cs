using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilhas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            string expressao = "3 4+ 2 * 5 - 2 /";
            Console.WriteLine("Q1 - Calcule o valor de uma expressão pós-fixada usando uma pilha\n- Input: {3 4+ 2 * 5 - 2 /}");
            Console.WriteLine($"- Resposta: {Q1.SeparaCaracteres(expressao)}"); 
        }
    }
}
