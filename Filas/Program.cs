using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            int[] valores = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine($"\nQ1 - Implemente uma pilha usando uma fila\n- Input: ({string.Join(", ", valores)})");
            Console.WriteLine($"- Peek(): {Pilha.Q1.Peek(valores)}");
            Console.WriteLine($"- Push(): {Pilha.Q1.Push(valores, 11)}");
            Console.WriteLine($"- Pop(): {Pilha.Q1.Pop(valores)}");
        }
    }
}
