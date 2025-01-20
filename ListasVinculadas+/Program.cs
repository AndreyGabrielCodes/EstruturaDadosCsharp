using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasVinculadas_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1
            LinkedList<int> numeros = new LinkedList<int>();
            int numeroElementos = 10;
            for(int i = 0; i < numeroElementos; i++)
            {
                numeros.AddLast(i);
            }
            Console.WriteLine($"Q1 - Ordene inversamente uma lista vinculada\n-Input: ({string.Join(",", numeros)})");
            Console.WriteLine($"- Resposta: ({Q1.ExibeListaInvertida(numeros)})");
        }
    }
}
