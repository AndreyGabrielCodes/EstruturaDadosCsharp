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

        }
    }
}
